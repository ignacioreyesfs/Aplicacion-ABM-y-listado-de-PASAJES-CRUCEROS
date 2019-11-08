using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoPuerto: AbstractRepo<Puerto>
    {
        public static RepoPuerto instancia = new RepoPuerto("[FGNN_19].[Puertos]");

        public RepoPuerto(string nombreTabla): base(nombreTabla) 
        {
        }

        public override List<Puerto> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Puerto> puertos = new List<Puerto>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = (String)row["descripcion"];

                Puerto puerto = new Puerto(id, descripcion);

                puertos.Add(puerto);
            }

            return puertos;
        }

        public List<Puerto> EncontrarPorDescripcionPuerto(string puerto)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE descripcion LIKE @DescripcionPatron";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("DescripcionPatron", "%" + puerto + "%"));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public override int Crear(Puerto entidad)
        {
            throw new NotImplementedException();
        }

        public String buscarValorID(Int32 id)
        {
            string sqlQuery = "SELECT p.descripcion FROM FGNN_19.Puertos p WHERE p.id = @id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("id", id));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return tabla.Rows[0][0].ToString();
        }
    }
}