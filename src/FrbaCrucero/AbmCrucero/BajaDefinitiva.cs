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
    public partial class BajaDefinitiva : Form
    {
        public BajaCrucero formBajaCrucero;
        public Int32 id;
        public BajaDefinitiva(BajaCrucero formBajaCrucero, Int32 id)
        {
            InitializeComponent();
            this.formBajaCrucero = formBajaCrucero;
            this.id = id;
        }

        private void button_ClickCancelarPasajes(object sender, EventArgs e)
        {
            this.cancelarPasajes(id);
            this.cerrarTodo();
            formBajaCrucero.listadoCruceros.buscar();
        }

        private void cancelarPasajes(Int32 id)
        {
            String sqlQuery = "FGNN_19.Cancelar_pasajes_crucero_definitiva";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idCrucero", id));
            cmd.Parameters.Add(new SqlParameter("motivo", "Crucero dado de baja definitiva"));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            ConexionDB.instancia.ejecutarQuery(cmd);
            MessageBox.Show("Se han cancelado los pasajes que involucraban al crucero.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void cerrarTodo()
        {
            this.Close();
            this.formBajaCrucero.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cambiarCruceroPasajes(id);
            this.cerrarTodo();
            formBajaCrucero.listadoCruceros.buscar();
        }

        private void cambiarCruceroPasajes(Int32 id)
        {
            String sqlQuery = "FGNN_19.Reemplazar_crucero";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idCrucero", id));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            String parametroOutput = "resultado";
            cmd.Parameters.Add(parametroOutput, SqlDbType.Int).Direction = ParameterDirection.Output;
            Int32 resultado = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmd, parametroOutput);
            if (resultado == 1)
            {
                MessageBox.Show("El crucero no puede ser reemplazado por ningun otro existente", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MessageBox.Show("Se ha cambiado el crucero con exito.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }

        }
    }
}
