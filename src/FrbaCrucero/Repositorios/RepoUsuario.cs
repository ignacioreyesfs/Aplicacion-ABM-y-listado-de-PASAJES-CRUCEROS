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
    class RepoUsuario : AbstractRepo<Usuario>
    {
        public static RepoUsuario instancia = new RepoUsuario("[FGNN_19].[Usuarios]");

        public RepoUsuario(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Usuario> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                string userName = (String)row["username"];
                string password = Convert.ToString(row["password"]);
                Int16 intentosFallidos = Convert.ToInt16(row["intentos_fallidos"]);
                Int16 habilitado = Convert.ToInt16(row["habilitado"]);

                Usuario usuario = new Usuario(id, userName, password, intentosFallidos, habilitado);
            
                usuarios.Add(usuario);
            }

            return usuarios;
        }

        public Usuario EncontrarPorUserName(string username)
        {
            String sqlQuery = "SELECT  *   FROM " + nombreTabla + " WHERE username = @UserName";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            SqlParameter parametro = new SqlParameter("UserName", username);
            cmd.Parameters.Add(parametro);

            DataTable tabla = conexionDB.obtenerData(cmd);
            return ObtenerModeloDesdeTabla(tabla);
        }

        public override int Crear(Usuario entidad)
        {
            throw new NotImplementedException();
        }
    }
}
