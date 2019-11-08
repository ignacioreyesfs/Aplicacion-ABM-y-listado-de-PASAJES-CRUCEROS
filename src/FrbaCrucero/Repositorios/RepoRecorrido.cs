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
    class RepoRecorrido : AbstractRepo<Recorrido>
    {
        public static RepoRecorrido instancia = new RepoRecorrido("[FGNN_19].[Recorridos]");

        public RepoRecorrido(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override int Crear(Recorrido recorrido)
        {
            string sqlQuery = "INSERT INTO " + nombreTabla + "(codigo, puerto_desde_id, puerto_hasta_id, precio_base, habilitado) "
                                             + "VALUES (@codigo, @puerto_desde_id, @puerto_hasta_id, @precio_base, @habilitado)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("codigo", recorrido.codigo));
            cmd.Parameters.Add(new SqlParameter("puerto_desde_id", recorrido.puertoDesde));
            cmd.Parameters.Add(new SqlParameter("puerto_hasta_id", recorrido.puertoHasta));
            cmd.Parameters.Add(new SqlParameter("habilitado", recorrido.habilitado));

            conexionDB.ejecutarQuery(cmd);

            return 1;
        }

        public Int32 Baja(Int32 id)
        {
            String sqlQuery = "UPDATE " + nombreTabla + " SET habilitado = 0 WHERE id = @idRecorrido SELECT @@ROWCOUNT";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("idRecorrido", id));
            DataTable resultado = conexionDB.obtenerData(cmd);
            return Int32.Parse(resultado.Rows[0][0].ToString());      
        }

        public override List<Recorrido> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Recorrido> recorridos = new List<Recorrido>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String codigo = (String)row["codigo"];
                String puertoDesde = this.buscarValorID(Convert.ToInt32(row["puerto_desde_id"]));
                String puertoHasta = this.buscarValorID(Convert.ToInt32(row["puerto_hasta_id"]));
                Int16 habilitado = Convert.ToInt16(row["habilitado"]);

                Recorrido recorrido = new Recorrido(id, codigo, puertoDesde, puertoHasta, habilitado);

                recorridos.Add(recorrido);
            }
            return recorridos;
        }

        public List<Recorrido> EncontrarPorParametros(String puertoDesde, String puertoHasta, Int16? habilitado)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE id > 0";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            if (!String.IsNullOrWhiteSpace(puertoDesde))
            {
                cmd.CommandText = cmd.CommandText + " AND puerto_desde_id = @puertoDesde";
                cmd.Parameters.Add(new SqlParameter("puertoDesde", puertoDesde));
            }

            if (!String.IsNullOrWhiteSpace(puertoHasta))
            {
                cmd.CommandText = cmd.CommandText + " AND puerto_hasta_id = @puertoHasta";
                cmd.Parameters.Add(new SqlParameter("puertoHasta", puertoHasta));
            }
            
            if (habilitado != null)
            {
                cmd.CommandText = cmd.CommandText + " AND habilitado = @Habilitado";
                cmd.Parameters.Add(new SqlParameter("Habilitado", habilitado));
            }

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
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
