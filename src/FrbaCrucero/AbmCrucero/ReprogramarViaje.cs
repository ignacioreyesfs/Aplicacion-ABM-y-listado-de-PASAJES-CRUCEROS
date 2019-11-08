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
    public partial class ReprogramarViaje : Form
    {
        DateTime fechaReinicioServicio;
        CancelarPasajesOReprogramar formCancelarPasajeOReprogramar;
        public ReprogramarViaje(DateTime fechaReinicioServicio, CancelarPasajesOReprogramar formCancelarPasajeOReprogramar)
        {
            InitializeComponent();
            this.fechaReinicioServicio = fechaReinicioServicio;
            this.formCancelarPasajeOReprogramar = formCancelarPasajeOReprogramar;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Int32 dias = Decimal.ToInt32(numericUpDownDias.Value);
            Int32 id = formCancelarPasajeOReprogramar.ID;
            if (this.esValidaFechaCorrimiento(id, dias, fechaReinicioServicio))
            {
                this.reprogramarViaje(id, dias);
                this.cerrarTodo();
                this.Buscar();
            }
            else
            {
                MessageBox.Show("No puede realizarse un viaje antes de la fecha de reinicio del servicio, "
                               +"revise los dias de corrimiento ingresados", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Buscar()
        {
            formCancelarPasajeOReprogramar.formBajaTemporal.formBajaCrucero.listadoCruceros.buscar();
        }

        private void cerrarTodo()
        {
            this.Close();
            this.formCancelarPasajeOReprogramar.Close();
            this.formCancelarPasajeOReprogramar.formBajaTemporal.Close();
            this.formCancelarPasajeOReprogramar.formBajaTemporal.formBajaCrucero.Close();
            this.formCancelarPasajeOReprogramar.formBajaTemporal.formBajaCrucero.listadoCruceros.Close();
        }

        private bool esValidaFechaCorrimiento(Int32 id, Int32 cantidadDias, DateTime fecha_reinicio_servicio)
        {
            String sqlQuery = "FGNN_19.Fecha_valida_corrimiento";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idCrucero", id));
            cmd.Parameters.Add(new SqlParameter("cantidadDias", cantidadDias));
            cmd.Parameters.Add(new SqlParameter("fecha_reinicio_servicio", fecha_reinicio_servicio));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            String parametroOutput = "@Resultado";
            cmd.Parameters.Add(parametroOutput, SqlDbType.Int).Direction = ParameterDirection.Output;
            Int32 resultado = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmd, parametroOutput);
            return resultado == 1;
        }

        private void reprogramarViaje(Int32 id, Int32 cantidadDias)
        {
            String sqlQuery = "FGNN_19.Reeprogramar_viajes_crucero";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idCrucero", id));
            cmd.Parameters.Add(new SqlParameter("cantidadDias", cantidadDias));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }
    }
}
