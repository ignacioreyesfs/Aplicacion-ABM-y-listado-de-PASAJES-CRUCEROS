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
    class RepoCompra : AbstractRepo<Compra>
    {
        public static RepoCompra instancia = new RepoCompra("[FGNN_19].[Compras]");

        public RepoCompra(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Compra> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Compra> compras = new List<Compra>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 codigo = Convert.ToInt32(row["codigo"]);
                Int32 codigoPasaje = Convert.ToInt32(row["codigo_pasaje"]);
                MetodoPago metodoPago = DBNull.Value.Equals(row["metodo_pago"]) ? null : RepoMetodoPago.instancia.EncontrarPorId(Convert.ToInt32(row["metodo_pago"]));
                DateTime fecha = Convert.ToDateTime(row["fecha"]);

                Compra compra = new Compra(codigo, codigoPasaje, metodoPago, fecha);

                compras.Add(compra);
            }

            return compras;
        }

        public override int Crear(Compra entidad)
        {
            throw new NotImplementedException();
        }

        public Compra EncontrarPorCodigo(Int32 codigo)
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
