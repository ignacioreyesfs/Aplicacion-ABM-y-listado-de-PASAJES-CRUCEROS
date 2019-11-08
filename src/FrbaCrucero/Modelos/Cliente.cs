using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCrucero.Modelos
{
    public class Cliente
    {
        public Int32 id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public Int32 dni { get; set; }
        public String direccion { get; set; }
        public Int32 telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String mail { get; set; }

        public Cliente(Int32 id, String nombre, String apellido, Int32 dni, String direccion, Int32 telefono,
            DateTime fechaNacimiento, String mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.mail = mail;
        }

        public Cliente(String nombre, String apellido, Int32 dni, String direccion, Int32 telefono,
            DateTime fechaNacimiento, String mail)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.mail = mail;
        }

        public Int32 Crear()
        {
            this.crearCliente();
            Int32 idCliente = this.idCreado();
            return idCliente;
        }

        public void Modificar(Int32 idCliente)
        {
            this.modificarCliente(idCliente);
        }

        private void modificarCliente(Int32 idCliente)
        {
            String sqlQuery = "UPDATE FGNN_19.Clientes SET nombre = @nombre, "
                            + "apellido = @apellido, direccion = @direccion, "
                            + "telefono = @telefono, fecha_nac = @fecha_nac, mail = @mail "
                            + "WHERE id = @idCliente";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("nombre", this.nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", this.apellido));
            cmd.Parameters.Add(new SqlParameter("direccion", this.direccion));
            cmd.Parameters.Add(new SqlParameter("telefono", this.telefono));
            cmd.Parameters.Add(new SqlParameter("fecha_nac", this.fechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("mail", this.mail));
            cmd.Parameters.Add(new SqlParameter("idCliente", idCliente));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        private void crearCliente()
        {
            String sqlQuery = "INSERT INTO FGNN_19.Clientes (nombre, apellido, dni, direccion, telefono, fecha_nac, mail) "
                            + "VALUES(@nombre,@apellido,@dni,@direccion,@telefono,@fecha_nac,@mail)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("nombre", this.nombre));
            cmd.Parameters.Add(new SqlParameter("apellido", this.apellido));
            cmd.Parameters.Add(new SqlParameter("direccion", this.direccion));
            cmd.Parameters.Add(new SqlParameter("telefono", this.telefono));
            cmd.Parameters.Add(new SqlParameter("fecha_nac", this.fechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("mail", this.mail));
            cmd.Parameters.Add(new SqlParameter("dni", this.dni));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }


        private Int32 idCreado()
        {
            String sqlQuery = "SELECT IDENT_CURRENT ('FGNN_19.Clientes')";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            DataTable resultado = ConexionDB.instancia.obtenerData(cmd);
            return Int32.Parse(resultado.Rows[0][0].ToString());
        }
    }
}
