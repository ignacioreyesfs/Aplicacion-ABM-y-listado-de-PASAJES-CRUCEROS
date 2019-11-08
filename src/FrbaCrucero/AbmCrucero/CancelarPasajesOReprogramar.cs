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

namespace FrbaCrucero.AbmCrucero
{
    public partial class CancelarPasajesOReprogramar : Form
    {
        public BajaTemporal formBajaTemporal;
        public Int32 ID;
        public CancelarPasajesOReprogramar(BajaTemporal formBajaTemporal, Int32 ID)
        {
            InitializeComponent();
            this.formBajaTemporal = formBajaTemporal;
            this.ID = ID;
        }

        private void buttonCancelarPasajes_Click(object sender, EventArgs e)
        {
            this.cancelarPasajes(ID);
            this.cerrarTodo();
            formBajaTemporal.formBajaCrucero.listadoCruceros.buscar();
        }

        private void cancelarPasajes(Int32 id)
        {
            String sqlQuery = "FGNN_19.Cancelar_pasajes_crucero";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idCrucero", id));
            cmd.Parameters.Add(new SqlParameter("motivo", "Crucero fuera de servicio"));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            cmd.Parameters.Add(new SqlParameter("fechaReinicio", Convert.ToDateTime(formBajaTemporal.textBoxFechaReinicioServicio.Text)));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        private void buttonReprogramarViajes_Click(object sender, EventArgs e)
        {
            String fecha = formBajaTemporal.textBoxFechaReinicioServicio.Text;
            if (String.IsNullOrWhiteSpace(fecha))
            {
                MessageBox.Show("Ingrese una fecha de reinicio de servicio valida", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                DateTime fechaReinicioServicio = Convert.ToDateTime(fecha);
                ReprogramarViaje reprogramarViaje = new ReprogramarViaje(fechaReinicioServicio, this);
                reprogramarViaje.Show();
            } 
        }

        private void cerrarTodo()
        {
            this.Close();
            this.formBajaTemporal.Close();
            this.formBajaTemporal.formBajaCrucero.Close();
        }
    }
}
