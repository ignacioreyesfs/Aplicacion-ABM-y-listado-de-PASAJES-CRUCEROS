using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FrbaCrucero.Utils;

namespace FrbaCrucero.Repositorios
{
    abstract class AbstractRepo<T>: IRepo<T> where T : class
    {
        protected string nombreTabla;
        protected ConexionDB conexionDB = ConexionDB.instancia;

        public AbstractRepo(string nombreTabla)
        {
            this.nombreTabla = nombreTabla;
        }

        public abstract List<T> ObtenerModelosDesdeTabla(DataTable tabla);
        public abstract Int32 Crear(T entidad);
        
        public void Eliminar(Int32 id)
        {
            String sqlQuery = "DELETE FROM " + nombreTabla + " WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            conexionDB.ejecutarQuery(cmd);
        }

        public void Modificar(Int32 id, Dictionary<string, object> parametros)
        {
            string sqlQuery = crearUpdateQuery(id, parametros);
            SqlCommand cmd = new SqlCommand(sqlQuery);

            foreach (string key in parametros.Keys) 
            {
                 cmd.Parameters.Add(new SqlParameter(key, parametros[key]));
            }

            cmd.Parameters.Add(new SqlParameter("Id", id));

            conexionDB.ejecutarQuery(cmd);
        }

        public List<T> EncontrarTodos()
        {
            String sqlQuery = "SELECT * FROM " + nombreTabla;
            DataTable tabla = conexionDB.obtenerData(sqlQuery);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public T EncontrarPorId(Int32 id)
        {
            String sqlQuery = "SELECT  *   FROM " + nombreTabla + " WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            SqlParameter parametro = new SqlParameter("id", id);
            cmd.Parameters.Add(parametro);

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }

        protected T ObtenerModeloDesdeTabla(DataTable tabla)
        {
            return ObtenerModelosDesdeTabla(tabla).First();
        }

        private string crearUpdateQuery(Int32 id, Dictionary<string, object> parametros)
        {
            string separador = "";
            string separadorComa = ", ";
            bool primeraIteracion = true;
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE ").Append(nombreTabla).Append(" SET ");

            foreach (string key in parametros.Keys) 
            {
                if (primeraIteracion)
                {
                    primeraIteracion = false;
                }
                else 
                {
                    sql.Append(separadorComa);
                }

                sql.Append(separador).Append(key).Append(" = @").Append(key);
            }

            sql.Append(" WHERE id = @Id");

            return sql.ToString();
        }

        public SqlCommand CreateProcedure(string storeProcedureName, List<SPContent> parameters)
        {
            SqlCommand storeProcedure = this.conexionDB.getStoreProcedure(storeProcedureName);
            if (parameters != null)
            {
                parameters.ForEach(delegate (SPContent parameter)
                {
                    if (parameter.Valor != null)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@" + parameter.Nombre, parameter.Valor);
                        storeProcedure.Parameters.Add(sqlParameter);
                    }
                    else
                    {
                        SqlParameter sqlParameter = new SqlParameter("@" + parameter.Nombre, parameter.Tipo);
                        sqlParameter.Direction = ParameterDirection.Output;
                        storeProcedure.Parameters.Add(sqlParameter);
                    }
                }
                );
            }
            return storeProcedure;
          }

        public void EliminacionLogica(Int32 id)
        {
            String sqlQuery = "UPDATE " + nombreTabla + " SET habilitado = 0 WHERE id = @Id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Id", id));
            conexionDB.ejecutarQuery(cmd);
        }

    }   
}
