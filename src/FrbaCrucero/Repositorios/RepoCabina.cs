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
    class RepoCabina : AbstractRepo<Cabina>
    {

        public static RepoCabina instancia = new RepoCabina("[FGNN_19].[Cabinas]");

        public RepoCabina(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Cabina> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Cabina> cabinas = new List<Cabina>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 codigo = Convert.ToInt32(row["codigo"]);
                Int32 crucero_id = Convert.ToInt32(row["crucero_id"]);
                Int32 numero = Convert.ToInt32(row["numero"]);
                Int32 piso = Convert.ToInt32(row["piso"]);
                TipoCabina tipoCabina = RepoTipoCabina.instancia.EncontrarPorId(Convert.ToInt32(row["tipo_id"]));
                Int16 estado = Convert.ToInt16(row["estado"]);

                Cabina cabina = new Cabina(codigo, crucero_id, numero, piso, tipoCabina, estado);

                cabinas.Add(cabina);
            }

            return cabinas;
        }

        public override int Crear(Cabina entidad)
        {
            throw new NotImplementedException();
        }

        public Cabina EncontrarPorCodigo(Int32 codigo)
        {
            String sqlQuery = "SELECT  *   FROM " + nombreTabla + " WHERE codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            SqlParameter parametro = new SqlParameter("Codigo", codigo);
            cmd.Parameters.Add(parametro);

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }
    }
}
