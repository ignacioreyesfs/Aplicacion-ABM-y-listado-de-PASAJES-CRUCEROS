using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Repositorios
{
    class RepoTramo : AbstractRepo<Tramo>
    {
        public static RepoTramo instancia = new RepoTramo("[FGNN_19].[Tramos]");

        public RepoTramo(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Tramo> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Tramo> tramos = new List<Tramo>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String puertoDesde = Repositorios.RepoPuerto.instancia.buscarValorID(Convert.ToInt32(row["puerto_desde_id"]));
                String puertoHasta = Repositorios.RepoPuerto.instancia.buscarValorID(Convert.ToInt32(row["puerto_hasta_id"]));
                Double precio_base = Convert.ToDouble(row["habilitado"]);

                Tramo tramo = new Tramo(id, puertoDesde, puertoHasta, precio_base);

                tramos.Add(tramo);
            }
            return tramos;
        }

        public void llenarDatos(DataGridView tablaTramosTotales)
        {
            String sqlQuery = "Select t.id, t.puerto_desde_id, t.puerto_hasta_id, pd.descripcion, ph.descripcion, t.precio_base from " 
                            + nombreTabla + " t, FGNN_19.Puertos pd, FGNN_19.Puertos ph WHERE pd.id = t.puerto_desde_id AND ph.id = t.puerto_hasta_id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramosTotales.DataSource = tabla;
            tablaTramosTotales.Columns[1].Visible = false;
            tablaTramosTotales.Columns["puerto_desde_id"].Visible = false;
            tablaTramosTotales.Columns["puerto_hasta_id"].Visible = false;
        }

        public DataTable tramosActuales(DataGridView tablaTramosActuales, Int32 idRecorrido, DataTable tabla)
        {
            String sqlQuery = "FGNN_19.P_TramosDelRecorrido";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            tabla = conexionDB.obtenerData(cmd);
            return tabla;
        }

        public bool tramoRecorridoOriginal(Int32 idTramo, Int32 idRecorrido)
        {
            String sqlQuery = "FGNN_19.P_TramoRecorridoOriginal";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idTramo", idTramo));
            cmd.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            DataTable tabla = conexionDB.obtenerData(cmd);
            return tabla.Rows.Count == 1;
            
        }

        public void eliminarTramo(Int32 idRecorrido, Int32 idTramo)
        {
            String sqlQuery = "DELETE FROM FGNN_19.Recorrido_X_Tramo WHERE recorrido_id = @idRecorrido AND tramo_id = @idTramo";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            cmd.Parameters.Add(new SqlParameter("idTramo", idTramo));
            conexionDB.ejecutarQuery(cmd);
        }

        public void actualizarDatosAgregar(List<Int32> tramos, DataGridView tablaTramos, String idPuertoDesde)
        {
            String sqlQuery = "Select t.id, t.puerto_desde_id, t.puerto_hasta_id, pd.descripcion, ph.descripcion, t.precio_base from "
                            + nombreTabla + " t, FGNN_19.Puertos pd, FGNN_19.Puertos ph WHERE pd.id = t.puerto_desde_id "
                            + "AND ph.id = t.puerto_hasta_id AND puerto_desde_id = @idPuertoDesde AND t.id NOT IN ({0})";
            String[] parametros = tramos.Select((s, i) => "@id" + i.ToString()).ToArray();

            String inClause = String.Join(", ", parametros);
            SqlCommand cmd = new SqlCommand(String.Format(sqlQuery, inClause));
            cmd.Parameters.AddWithValue("idPuertoDesde", idPuertoDesde);
            using (cmd)
            {
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(parametros[i], tramos[i]));
                }
            }
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramos.DataSource = tabla;
        }

        public void actualizarDatosQuitar(List<Int32> tramos, DataGridView tablaTramos, String idPuertoHasta)
        {
            String sqlQuery = "Select t.id, t.puerto_desde_id, t.puerto_hasta_id, pd.descripcion, ph.descripcion, t.precio_base from "
                            + nombreTabla + " t, FGNN_19.Puertos pd, FGNN_19.Puertos ph WHERE pd.id = t.puerto_desde_id "
                            + "AND ph.id = t.puerto_hasta_id AND puerto_desde_id = @idPuertoHasta AND t.id NOT IN ({0})";
            String[] parametros = tramos.Select((s, i) => "@id" + i.ToString()).ToArray();

            String inClause = String.Join(", ", parametros);
            SqlCommand cmd = new SqlCommand(String.Format(sqlQuery, inClause));
            cmd.Parameters.AddWithValue("idPuertoHasta", idPuertoHasta);
            using (cmd)
            {
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(parametros[i], tramos[i]));
                }
            }
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramos.DataSource = tabla;
        }

        public void actualizarDatos(DataGridView tablaTramos, String idPuertoDesde)
        {
            String sqlQuery = "Select t.id, t.puerto_desde_id, t.puerto_hasta_id, pd.descripcion, ph.descripcion, t.precio_base from "
                            + nombreTabla + " t, FGNN_19.Puertos pd, FGNN_19.Puertos ph WHERE pd.id = t.puerto_desde_id "
                            + "AND ph.id = t.puerto_hasta_id AND t.puerto_desde_id = @idPuertoDesde";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("idPuertoDesde", idPuertoDesde);
            DataTable tabla = conexionDB.obtenerData(cmd);
            tablaTramos.DataSource = tabla;
        }

        public override int Crear(Tramo tramo)
        {
            throw new NotImplementedException();
        }

        public void vaciarRegistro(Int32 idRecorrido)
        {
            String sqlQuery = "DELETE FROM FGNN_19.Recorrido_X_Tramo WHERE recorrido_id = @idRecorrido";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            conexionDB.ejecutarQuery(cmd);
        }
    }
}
