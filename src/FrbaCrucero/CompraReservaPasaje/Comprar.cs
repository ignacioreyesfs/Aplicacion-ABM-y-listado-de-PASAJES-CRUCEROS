using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Modelos;
using System.Data.SqlClient;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Comprar : Form
    {
        CrearPasaje pasaje;
        String descPuertoSalida;
        String descPuertoLlegada;
        String fechaSalida;
        String fechaLlegada;
        String cruceroNombre;
        String cabinaNumero;

        public Comprar(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
            this.textBoxPrecio.Text = (pasaje.pasajeros * this.precioPasaje()).ToString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String metodoDePagoDesc = comboBoxMetodoDePago.Text;
            Int32 cuotas = metodoDePagoDesc == "Tarjeta de crédito" ? Decimal.ToInt32(numericUpDownCuotas.Value) : 0;
            Int32 idMetodoPago = this.obtenerIDMetodoPago(comboBoxMetodoDePago.Text);
            Int32 idCompra = new CrearCompra(idMetodoPago, cuotas).Crear();
            Int32 pasajeros = pasaje.pasajeros;
            while (pasaje.pasajeros > 0)
            {
                new CrearPasaje(null, pasaje.cliente_id, idCompra, pasaje.viaje_codigo, pasaje.cabina_id).Crear();
                pasaje.pasajeros--;
            }

            this.setDatosMostrarPasaje(pasaje.viaje_codigo, pasaje.cabina_id);

            MessageBox.Show("La compra del pasaje resulto exitosa. \n Datos de la compra: \n " +
                "\n - Voucher de compra: " + idCompra + "\n - Puerto de salida: " + descPuertoSalida + "\n - Puerto de llegada: " + descPuertoLlegada + "\n - Fecha de salida: " + fechaSalida +
                "\n - Fecha de llegada: " + fechaLlegada + "\n - Crucero: " + cruceroNombre + "\n - Cabina numero: " + cabinaNumero +
                "\n - Cantidad de pasajeros: " + pasajeros + "\n - Metodo de pago: " + comboBoxMetodoDePago.Text, 
                "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void comboBoxMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoDePago.Text != "Tarjeta de crédito")
            {
                numericUpDownCuotas.Visible = false;
            }
            else
            {
                numericUpDownCuotas.Visible = true;
            }
        }

        private Double precioPasaje()
        {
            String parametroOutput = "precio_final";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Calcular_costo_pasaje");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("idViaje", pasaje.viaje_codigo));
            cmdInsertar.Parameters.Add(new SqlParameter("idCabina", pasaje.cabina_id));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            return ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
        }

        private Int32 obtenerIDMetodoPago(String descripcion)
        {
            String parametroOutput = "id";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Obtener_id_metodo_pago");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("descripcion", descripcion));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            return ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
        }

        private void setDatosMostrarPasaje(Int32 idViaje, Int32 idCabina)
        {
            String parametroOutputPS = "@descripcionPS";
            String parametroOutputPL = "@descripcionPL";
            String parametroOutputFS = "@fecha_salida";
            String parametroOutputFL = "@fecha_llegada";
            String parametrOutputCN = "@crucero_nombre";
            String parametroOutputCabN = "@cabina_numero";
            String sqlQuery = "FGNN_19.Obtener_datos_mostrar_pasaje";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("id_viaje", idViaje));
            cmd.Parameters.Add(new SqlParameter("id_cabina", idCabina));
            cmd.Parameters.Add(parametroOutputPS, SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parametroOutputPL, SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parametroOutputFS, SqlDbType.DateTime2).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parametroOutputFL, SqlDbType.DateTime2).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parametrOutputCN, SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parametroOutputCabN, SqlDbType.Int).Direction = ParameterDirection.Output;
            List<String> parametros = new List<String>(new String [] {parametroOutputPS, parametroOutputPL, parametroOutputFS, parametroOutputFL, parametrOutputCN, parametroOutputCabN});
            List<object> listDatosPasaje = ConexionDB.instancia.ejecutarStoredProcedureConOutputs(cmd, parametros);
            descPuertoLlegada = listDatosPasaje[0].ToString();
            descPuertoSalida = listDatosPasaje[1].ToString();
            fechaSalida = listDatosPasaje[2].ToString();
            fechaLlegada = listDatosPasaje[3].ToString();
            cruceroNombre = listDatosPasaje[4].ToString();
            cabinaNumero = listDatosPasaje[5].ToString();
        }

    }
}
