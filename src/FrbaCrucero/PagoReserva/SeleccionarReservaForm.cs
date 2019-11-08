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

namespace FrbaCrucero.PagoReserva
{
    public partial class SeleccionarReservaForm : Form
    {
        public SeleccionarReservaForm()
        {
            InitializeComponent();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.actualizarReservas(); 
            Int32 codigo = Convert.ToInt32(numericUpDownCodigo.Value);

            Reserva reserva = RepoReserva.instancia.EncontrarPorCodigoConPasajeNoCompradoYHabilitado(codigo);
            if (reserva == null)
            {
                string texto = "No se encontró una reserva pagar con ese codigo";
                DialogResult dr = MessageBox.Show(
                    texto,
                    "Reserva no encontrada",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            else 
            {
                List<Pasaje> pasajes = RepoPasaje.instancia.EncontrarPorCodigoReserva(reserva.codigo); 

                ReservaForm reservaForm = new ReservaForm(pasajes);
                reservaForm.Show();
                this.Close();
            }
        }

        private void actualizarReservas()
        {
            String sqlQuery = "FGNN_19.Actualizar_Reservas";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }
    }
}
