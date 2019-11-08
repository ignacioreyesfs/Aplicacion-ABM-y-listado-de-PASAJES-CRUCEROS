using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoReserva : AbstractRepo<Reserva>
    {
        public static RepoReserva instancia = new RepoReserva("[FGNN_19].[Reservas]");
        public static string TABLA_PASAJE = "[FGNN_19].[PASAJES]";

        public RepoReserva(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Reserva> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Reserva> reservas = new List<Reserva>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 codigo = Convert.ToInt32(row["id"]);
                Int16 habilitado = Convert.ToInt16(row["habilitada"]);
                DateTime fecha = Convert.ToDateTime(row["fecha"]);

                Reserva reserva = new Reserva(codigo, habilitado, fecha);

                reservas.Add(reserva);
            }

            return reservas;
        }

        public override int Crear(Reserva entidad)
        {
            throw new NotImplementedException();
        }

        public Reserva EncontrarPorCodigo(Int32 codigo)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE id = @Codigo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Codigo", codigo));

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }

        public Reserva EncontrarPorCodigoConPasajeNoCompradoYHabilitado(Int32 codigo)
        {
            string sqlQuery = "SELECT r.* FROM " + nombreTabla + " r, " +  TABLA_PASAJE + " p, FGNN_19.Viajes v WHERE p.reserva_codigo = r.id "
                            + "AND p.compra_codigo IS NULL AND r.id = @Codigo AND r.habilitada = 1 AND p.viaje_codigo = v.codigo "
                            + "AND v.fecha_inicio > @fechaHoy";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Codigo", codigo));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));

            DataTable tabla = conexionDB.obtenerData(cmd);
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ObtenerModeloDesdeTabla(tabla);
            }
        }
    }
}
