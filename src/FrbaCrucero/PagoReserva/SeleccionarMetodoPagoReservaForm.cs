using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.PagoReserva
{
    public partial class SeleccionarMetodoPagoReservaForm : Form
    {
        private List<Pasaje> pasajes;
        private Double totalAPagar;
        String descPuertoSalida;
        String descPuertoLlegada;
        String fechaSalida;
        String fechaLlegada;
        String cruceroNombre;
        String cabinaNumero;

        public SeleccionarMetodoPagoReservaForm(List<Pasaje> pasajes, Double totalAPagar)
        {
            InitializeComponent();
            this.pasajes = pasajes;
            this.totalAPagar = totalAPagar;
            labelTotalAPagarInfo.Text = "$ " + totalAPagar.ToString();
            numericUpDownCuotas.Value = 1;
            comboBoxMetodoDePago.SelectedIndex = 0;
        }

        private void comboBoxMetodoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoDePago.Text != "Tarjeta de crédito")
            {
                numericUpDownCuotas.ReadOnly = true;
                labelCuotas.Visible = false;
                numericUpDownCuotas.Visible = false;
            }
            else
            {
                labelCuotas.Visible = true;
                numericUpDownCuotas.Visible = true;
                numericUpDownCuotas.ReadOnly = false;
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            String metodoDePagoDesc = comboBoxMetodoDePago.Text;
            Int32 cuotas = metodoDePagoDesc == "Tarjeta de crédito" ? Decimal.ToInt32(numericUpDownCuotas.Value) : 0;
            Int32 idMetodoPago = this.obtenerIDMetodoPago(comboBoxMetodoDePago.Text);
            Int32 idCompra = new CrearCompra(idMetodoPago, cuotas).Crear();

            Dictionary<string, object> paramametrosAModificar = new Dictionary<string, object>();
            paramametrosAModificar.Add("compra_codigo", idCompra);
            
            pasajes.ForEach(pasaje => RepoPasaje.instancia.Modificar(pasaje.id, paramametrosAModificar));

            MessageBox.Show("Se pago la reserva de forma exitosa.", "Exito",
            MessageBoxButtons.OK, MessageBoxIcon.None);

            this.setDatosMostrarPasaje(pasajes[0].viaje.id, pasajes[0].cabina.codigo);

            MessageBox.Show("La compra del pasaje resulto exitosa. \n Datos de la compra: \n " +
                "- Puerto de salida: " + descPuertoSalida + "\n - Puerto de llegada: " + descPuertoLlegada + "\n - Fecha de salida: " + fechaSalida +
                "\n - Fecha de llegada: " + fechaLlegada + "\n - Crucero: " + cruceroNombre + "\n - Cabina numero: " + cabinaNumero +
                "\n - Cantidad de pasajeros: " + pasajes.Count + "\n - Metodo de pago: " + comboBoxMetodoDePago.Text,
                "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            
            this.Close();
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
            List<String> parametros = new List<String>(new String[] { parametroOutputPS, parametroOutputPL, parametroOutputFS, parametroOutputFL, parametrOutputCN, parametroOutputCabN });
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
