using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class CrearRecorridoXTramo
    {
        public Int32 idRecorrido { get; set; }
        public Int32 idTramo { get; set; }
        public Int32 orden { get; set; }

        public CrearRecorridoXTramo(Int32 idRecorrido, Int32 idTramo, Int32 orden)
        {
            this.idRecorrido = idRecorrido;
            this.idTramo = idTramo;
            this.orden = orden;
        }

        public void Crear()
        {
            this.insertarRecorridoXTramo();
        }

        private void insertarRecorridoXTramo()
        {
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.P_IngresarRecorrido_X_Tramo");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            cmdInsertar.Parameters.Add(new SqlParameter("idTramo", idTramo));
            cmdInsertar.Parameters.Add(new SqlParameter("orden", orden));
            ConexionDB.instancia.ejecutarQuery(cmdInsertar);
        }
    }
}
