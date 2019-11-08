using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Modelos
{
    class CrearViaje
    {
        public Int32 crucero_id { get; set; }
        public Int32 recorrido_codigo { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }

        public CrearViaje(Int32 crucero_id, Int32 recorrido_codigo, DateTime fecha_inicio, DateTime fecha_fin)
        {
            this.crucero_id = crucero_id;
            this.recorrido_codigo = recorrido_codigo;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }

        public void Crear()
        {
            if (this.validarViaje())
            {
                this.InsertarViaje();
                MessageBox.Show("Se ha ingresado el viaje con exito.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("El viaje ingresado tiene algunos parametros no validos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarViaje()
        {
            SqlCommand cmdValidar = new SqlCommand("FGNN_19.P_Viaje_valido");
            cmdValidar.CommandType = CommandType.StoredProcedure;
            cmdValidar.Parameters.Add(new SqlParameter("idCrucero", crucero_id));
            cmdValidar.Parameters.Add(new SqlParameter("idRecorrido", recorrido_codigo));
            cmdValidar.Parameters.Add(new SqlParameter("fechaInicio", fecha_inicio));
            cmdValidar.Parameters.Add(new SqlParameter("fechaFin", fecha_fin));
            String parametroOutput = "@Resultado";
            cmdValidar.Parameters.Add(parametroOutput, SqlDbType.Int).Direction = ParameterDirection.Output;
            Int32 resultado = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdValidar, parametroOutput);
            return resultado == 1;
        }

        private void InsertarViaje()
        {
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.P_InsertarViaje");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("idCrucero", crucero_id));
            cmdInsertar.Parameters.Add(new SqlParameter("idRecorrido", recorrido_codigo));
            cmdInsertar.Parameters.Add(new SqlParameter("fechaInicio", fecha_inicio));
            cmdInsertar.Parameters.Add(new SqlParameter("fechaFin", fecha_fin));
            ConexionDB.instancia.ejecutarQuery(cmdInsertar);
        }
    }
}
