using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraPasaje
{
    public partial class CompraReservaPasajeForm : Form
    {
        public CompraReservaPasajeForm()
        {
            InitializeComponent();
            this.textBoxFechaInicio.ReadOnly = true;
            this.textBoxFechaFin.ReadOnly = true;
            this.textBoxPuertoDestino.ReadOnly = true;
            this.textBoxPuertoOrigen.ReadOnly = true;
        }

        private void buttonSeleccionarFechaInicio_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxFechaInicio);
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaFin_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxFechaFin);
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarPuertoOrigen_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(textBoxPuertoOrigen);
            seleccionarPuerto.Show();
        }

        private void buttonSeleccionarPuertoDestino_Click(object sender, EventArgs e)
        {
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(textBoxPuertoDestino);
            seleccionarPuerto.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        public void Buscar()
        {
            string valorPuertoDesde = textBoxPuertoOrigen.Text;
            string valorPuertoHasta = textBoxPuertoDestino.Text;
            string fechaInicio = textBoxFechaInicio.Text;
            string fechaFin = textBoxFechaFin.Text;

            List<Viaje> viajes = RepoViaje.instancia
                                          .EncontrarPorParametros(valorPuertoDesde, valorPuertoHasta, fechaInicio, fechaFin);
            dataGridViewViajes.DataSource = viajes;
            dataGridViewViajes.MultiSelect = false;
            this.dataGridViewViajes.Columns["fecha_fin_estimada"].Visible = false;
            this.dataGridViewViajes.Columns[1].Visible = false;
            this.dataGridViewViajes.Columns[2].Visible = false;
            this.dataGridViewViajes.Columns[3].Visible = false;
            this.actualizarViajes();
        }

        private void actualizarViajes()
        {
            String sqlQuery = "FGNN_19.Actualizar_Viajes";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxFechaInicio.Text = null;
            this.textBoxFechaFin.Text = null;
            this.textBoxPuertoOrigen.Text = null;
            this.textBoxPuertoDestino.Text = null;
        }

        private void dataGridViewViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Int32 idCrucero = Int32.Parse(dataGridViewViajes[2, e.RowIndex].Value.ToString());
                Int32 idViaje = Int32.Parse(dataGridViewViajes[1, e.RowIndex].Value.ToString());
                CrearPasaje nuevoPasaje = new CrearPasaje();
                nuevoPasaje.viaje_codigo = idViaje;
                SeleccionarCabina seleccionarCabina = new SeleccionarCabina(idCrucero, nuevoPasaje);
                seleccionarCabina.Show();

            }        
        }
    }
}
