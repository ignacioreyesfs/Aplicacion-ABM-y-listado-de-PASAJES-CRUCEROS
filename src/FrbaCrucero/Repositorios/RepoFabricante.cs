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
    class RepoFabricante: AbstractRepo<Fabricante>
    {
        public static RepoFabricante instancia = new RepoFabricante("[FGNN_19].[Fabricantes]");

        public RepoFabricante(string nombreTabla): base(nombreTabla) 
        {
        }

        public override List<Fabricante> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Fabricante> fabricantes = new List<Fabricante>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = (String)row["descripcion"];

                Fabricante fabricante = new Fabricante(id, descripcion);

                fabricantes.Add(fabricante);
            }

            return fabricantes;
        }

        public List<Fabricante> EncontrarPorDescripcionFabricante(string fabricante)
        {
            string sqlQuery = "SELECT * FROM" + nombreTabla + " WHERE descripcion LIKE @FabricantePattern";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("FabricantePattern", fabricante + "%"));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public override int Crear(Fabricante entidad)
        {
            throw new NotImplementedException();
        }
    }
}
