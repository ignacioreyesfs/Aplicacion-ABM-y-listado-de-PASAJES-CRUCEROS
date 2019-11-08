using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class CrearRecorrido
    {
        public String codigo { get; set; }
        public Int32 puertoDesde { get; set; }
        public Int32 puertoHasta { get; set; }

        public CrearRecorrido(String codigo, Int32 puertoDesde, Int32 puertoHasta)
        {
            this.codigo = codigo;
            this.puertoDesde = puertoDesde;
            this.puertoHasta = puertoHasta;
        }

        public Int32 Crear()
        {
            Int32 id = this.insertarRecorrido();
            return id;
        }

        private Int32 insertarRecorrido()
        {
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.P_IngresarRecorrido");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("Codigo", codigo));
            cmdInsertar.Parameters.Add(new SqlParameter("idPuertoDesde", puertoDesde));
            cmdInsertar.Parameters.Add(new SqlParameter("idPuertoHasta", puertoHasta));
            String parametroOutput = "@idRecorridoIngresado";
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Int).Direction = ParameterDirection.Output;
            Int32 resultado = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
            return resultado;
        }
    }
}
