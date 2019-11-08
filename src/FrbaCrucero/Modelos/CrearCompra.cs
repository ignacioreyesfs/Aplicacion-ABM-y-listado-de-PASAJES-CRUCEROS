using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaCrucero.Modelos
{
    class CrearCompra
    {
        Int32 metodo_pago { get; set; }
        Int32 cuotas { get; set; }

        public CrearCompra(Int32 metodo_pago, Int32 cuotas)
        {
            this.metodo_pago = metodo_pago;
            this.cuotas = cuotas;
        }

        public Int32 Crear()
        {
            String parametroOutput = "@codigo";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Insertar_Compra");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("metodo_pago", metodo_pago));
            cmdInsertar.Parameters.Add(new SqlParameter("cuotas", cuotas));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmdInsertar.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            Int32 codigo = ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
            return codigo;
        }
    }
}
