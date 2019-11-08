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
    class RepoPasaje : AbstractRepo<Pasaje>
    {

        public static RepoPasaje instancia = new RepoPasaje("[FGNN_19].[Pasajes]");


        public RepoPasaje(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Pasaje> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Pasaje> pasajes = new List<Pasaje>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                Reserva reserva = DBNull.Value.Equals(row["reserva_codigo"]) ? null : RepoReserva.instancia.EncontrarPorCodigo(Convert.ToInt32(row["reserva_codigo"]));
                Cliente cliente = RepoCliente.instancia.EncontrarPorId(Convert.ToInt32(row["cliente_id"]));
                Compra compra = DBNull.Value.Equals(row["compra_codigo"]) ? null : RepoCompra.instancia.EncontrarPorCodigo(Convert.ToInt32(row["compra_codigo"]));
                Viaje viaje = RepoViaje.instancia.EncontrarPorCodigo(Convert.ToInt32(row["viaje_codigo"]));
                Cabina cabina = RepoCabina.instancia.EncontrarPorCodigo(Convert.ToInt32(row["cabina_id"]));
                Double? precio;
                if(DBNull.Value.Equals(row["precio"]))
                {
                    precio = null;
                }
                else
                {
                    precio = Convert.ToDouble(row["precio"]);
                }

                Int32? codigo;
                if (DBNull.Value.Equals(row["codigo"]))
                {
                    codigo = null;
                }
                else
                {
                    codigo = Convert.ToInt32(row["codigo"]);
                } 

                Pasaje pasaje = new Pasaje(id, reserva, cliente, compra, viaje, cabina, precio, codigo);

                pasajes.Add(pasaje);
            }

            return pasajes;
        }

        public override int Crear(Pasaje entidad)
        {
            throw new NotImplementedException();
        }

        public List<Pasaje> EncontrarPorCodigoReserva(Int32 codigo)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE reserva_codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Codigo", codigo));

            DataTable tabla = conexionDB.obtenerData(cmd);
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ObtenerModelosDesdeTabla(tabla);
            }
        }
    }
}
