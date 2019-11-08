using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace FrbaCrucero.Repositorios
{
    class RepoRol: AbstractRepo<Rol>
    {
        public static string TABLA_USUARIOS_ROLES = "[FGNN_19].[Usuarios_Roles]";
        public static string TABLA_FUNCIONALIDADES_ROLES = "[FGNN_19].[Funcionalidades_Roles]";
        public static RepoRol instancia = new RepoRol("[FGNN_19].[Roles]");

        public RepoRol(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override Int32 Crear(Rol rol)
        {
            string sqlQuery = "INSERT INTO " + nombreTabla + "(descripcion, habilitado) VALUES (@Descripcion, @Habilitado ); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Descripcion", rol.descripcion));
            cmd.Parameters.Add(new SqlParameter("Habilitado", rol.habilitado));

            return conexionDB.ejecutarQueryInsert(cmd);
        }

        public override List<Rol> ObtenerModelosDesdeTabla(DataTable table)
        {
            List<Rol> roles = new List<Rol>();

            foreach (DataRow row in table.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = (String)row["descripcion"];
                Int16 habilitado = Convert.ToInt16(row["habilitado"]);

                Rol rol = new Rol(id, descripcion, habilitado);
                List<Funcionalidad> funcionalidades = RepoFuncionalidad.instancia.findByRol(rol);

                rol.funcionalidades = funcionalidades;

                roles.Add(rol);
            }

            return roles;
        }

        public List<Rol> EncontrarPorDescripcionYHabilitado(String descripcion, Int16 habilatado, Boolean filtarPorValor)
        {
            string sqlQuery = "SELECT * FROM " + nombreTabla + " WHERE descripcion like @DescripcionPatron";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("DescripcionPatron", descripcion + "%"));
            if (filtarPorValor)
            {
                cmd.CommandText = cmd.CommandText + " AND habilitado = @Habilitado";
                cmd.Parameters.Add(new SqlParameter("Habilitado", habilatado));
            }

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModelosDesdeTabla(tabla);
        }

        public void DeshabilitarRol(Int32 id) 
        {
            this.EliminarRolDeUsuario(id);
            this.EliminacionLogica(id);
        }

        public void HabilitarRol(Int32 id)
        {
            string sqlQuery = "UPDATE " + nombreTabla + "SET habilitado = 1 WHERE id = @Id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Id", id));
            conexionDB.ejecutarQuery(cmd);
        }

        public void EliminarRolDeUsuario(Int32 id)
        {
            string sqlQuery = "DELETE " + TABLA_USUARIOS_ROLES + " WHERE rol_id = @Id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Id", id));
            conexionDB.ejecutarQuery(cmd);
        }

        public void ActualizarFuncinalidades(Rol rol)
        {
            this.EliminarTodasFuncionalidades(rol);
            this.InsertarFuncionalidades(rol);
        }


        public void EliminarTodasFuncionalidades(Rol rol)
        {
            string sqlQuery = "DELETE " + TABLA_FUNCIONALIDADES_ROLES + " WHERE rol_id = @Id";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("Id", rol.id));
            conexionDB.ejecutarQuery(cmd);
        }

        public void InsertarFuncionalidades(Rol rol)
        {
            bool primeraIteracion = true;
            string coma = ", ";
            StringBuilder sqlQueryBuilder = new StringBuilder();
            sqlQueryBuilder.Append("INSERT INTO " + TABLA_FUNCIONALIDADES_ROLES + " (rol_id, funcionalidad_id) VALUES ");
            List<Funcionalidad> funcionalidades = rol.funcionalidades;
            foreach(Funcionalidad f in funcionalidades) 
            {
                if (primeraIteracion)
                {
                    sqlQueryBuilder.Append("( " + rol.id + ", " + f.id + ")");
                    primeraIteracion = false;
                }
                else
                {
                    sqlQueryBuilder.Append(coma).Append("( " + rol.id + ", " + f.id + ")");
                }
            }

            sqlQueryBuilder.Append(";");

            string sqlQuery = sqlQueryBuilder.ToString();
            SqlCommand cmd = new SqlCommand(sqlQuery);
            conexionDB.ejecutarQuery(cmd);
        }

        public Rol EncontrarPorUsuario(Usuario usuario)
        {
            Int32 idUsuario = usuario.id;
            string sqlQuery = "SELECT t1.* FROM " + nombreTabla + " t1, " + TABLA_USUARIOS_ROLES + " t2 WHERE t2.usuario_id = @IdUsuario"; 
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("IdUsuario", idUsuario));

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }
    }
}
