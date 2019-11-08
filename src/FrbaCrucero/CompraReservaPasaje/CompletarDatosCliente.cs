using FrbaCrucero.CompraPasaje;
using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class CompletarDatosCliente : Form
    {
        CrearPasaje pasaje;
        Int32 idCliente;
        public CompletarDatosCliente(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
            textBoxNombre.ReadOnly = true;
            textBoxApellido.ReadOnly = true;
            textBoxDireccion.ReadOnly = true;
            textBoxTelefono.ReadOnly = true;
            textBoxFechaNacimiento.ReadOnly = true;
            textBoxMail.ReadOnly = true;
            buttonSeleccionarFecha.Enabled = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.habilitarEdicion();
        }

        private void habilitarEdicion()
        {
            textBoxNombre.ReadOnly = false;
            textBoxApellido.ReadOnly = false;
            textBoxDireccion.ReadOnly = false;
            textBoxTelefono.ReadOnly = false;
            textBoxMail.ReadOnly = false;
            buttonSeleccionarFecha.Enabled = true;
        }

        private void limpiarDatos()
        {
            textBoxNombre.Text = null;
            textBoxApellido.Text = null;
            textBoxDireccion.Text = null;
            textBoxTelefono.Text = null;
            textBoxFechaNacimiento.Text = null;
            textBoxMail.Text = null;
        }

        private bool todosSonNulos(List<object> parametros)
        {
            return parametros.All(valor => String.IsNullOrEmpty(valor.ToString()));
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxDNI.Text))
            {
                Int32 dniCliente = Int32.Parse(textBoxDNI.Text);
                List<object> datosDelCliente = this.datosCliente(dniCliente);

                if (!this.todosSonNulos(datosDelCliente))
                {
                    idCliente = Int32.Parse(datosDelCliente[0].ToString());
                    textBoxNombre.Text = datosDelCliente[1].ToString();
                    textBoxApellido.Text = datosDelCliente[2].ToString();
                    textBoxDireccion.Text = datosDelCliente[3].ToString();
                    textBoxTelefono.Text = datosDelCliente[4].ToString();
                    textBoxFechaNacimiento.Text = datosDelCliente[5].ToString();
                    textBoxMail.Text = datosDelCliente[6].ToString();
                    textBoxDNI.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no existe en la base de datos, ingrese sus datos para registrarse", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.habilitarEdicion();
                    this.limpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado no es valido, intente nuevamente", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void agregarParametroOutput(SqlCommand command, String parametroOutput, SqlDbType tipo)
        {
            if (tipo != SqlDbType.VarChar)
            {
                command.Parameters.Add(parametroOutput, tipo).Direction = ParameterDirection.Output;
            }
            else
            {
                command.Parameters.Add(parametroOutput, tipo, 255).Direction = ParameterDirection.Output;
            }
            
        }

        private List<object> datosCliente(Int32 dniCliente)
        {
            String sqlQuery = "FGNN_19.Datos_cliente";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("dni", dniCliente));
            this.agregarParametroOutput(cmd, "@id", SqlDbType.Int);
            this.agregarParametroOutput(cmd, "@nombre", SqlDbType.VarChar);
            this.agregarParametroOutput(cmd, "@apellido", SqlDbType.VarChar);
            this.agregarParametroOutput(cmd, "@direccion", SqlDbType.VarChar);
            this.agregarParametroOutput(cmd, "@telefono", SqlDbType.Int);
            this.agregarParametroOutput(cmd, "@fecha_nac", SqlDbType.DateTime2);
            this.agregarParametroOutput(cmd, "@mail", SqlDbType.VarChar);
            List<String> parametros = new List<String>();
            this.agregarParametros(parametros);
            List<object> listDatosCliente = ConexionDB.instancia.ejecutarStoredProcedureConOutputs(cmd, parametros);
            return listDatosCliente;
        }

        private void agregarParametros(List<String> parametros)
        {
            parametros.Add("@id");
            parametros.Add("@nombre");
            parametros.Add("@apellido");
            parametros.Add("@direccion");
            parametros.Add("@telefono");
            parametros.Add("@fecha_nac");
            parametros.Add("@mail");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarDatos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombre.Text;
            String apellido = textBoxApellido.Text;
            String dni = textBoxDNI.Text;
            String direccion = textBoxDireccion.Text;
            String telefono = textBoxTelefono.Text;
            String fecha_nac = textBoxFechaNacimiento.Text;
            String mail = textBoxMail.Text;

            Dictionary<String, string> parametrosObligatorios = new Dictionary<String, string>();
            parametrosObligatorios.Add("nombre", nombre);
            parametrosObligatorios.Add("apellido", apellido);
            parametrosObligatorios.Add("dni", dni);
            parametrosObligatorios.Add("direccion", direccion);
            parametrosObligatorios.Add("telefono", telefono);
            parametrosObligatorios.Add("fecha de nacimiento", fecha_nac);
            if (parametrosObligatorios.Any(parametro => this.ValidarNulo(parametro.Value)))
            {
                foreach (KeyValuePair<string, string> parametro in parametrosObligatorios)
                {
                    if (this.ValidarNulo(parametro.Value))
                        MessageBox.Show("No se puede dejar el campo " + parametro.Key + " vacio.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Cliente cliente = new Cliente(nombre, apellido, 
                                             Int32.Parse(dni), direccion, 
                                             Int32.Parse(telefono), 
                                             Convert.ToDateTime(fecha_nac), mail);
                if (this.existeElCliente(dni))
                {
                    cliente.Modificar(idCliente);
                }
                else
                {
                    idCliente = cliente.Crear();
                    MessageBox.Show("Se ha creado con exito.", "Exito",
                                    MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                if (this.puedeViajar(idCliente, pasaje.viaje_codigo) == 1)
                {
                    pasaje.cliente_id = idCliente;
                    SeleccionarCompraOReserva seleccionarCompraOReserva = new SeleccionarCompraOReserva(pasaje);
                    seleccionarCompraOReserva.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El cliente ingresado ya posee un viaje en esa fecha.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private Int32 puedeViajar(Int32 idCliente, Int32 viaje_codigo)
        {
            String sqlQuery = "FGNN_19.P_PuedeViajarCliente";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("codigoViaje", viaje_codigo));
            cmd.Parameters.Add(new SqlParameter("idCliente", idCliente));
            DataTable resultado = ConexionDB.instancia.obtenerData(cmd);
            return Int32.Parse(resultado.Rows[0][0].ToString());
        }

        private bool existeElCliente(string dni)
        {
            String sqlQuery = "select * from FGNN_19.Clientes WHERE dni = @dni";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("dni", Int32.Parse(dni)));
            DataTable resultado = ConexionDB.instancia.obtenerData(cmd);
            return resultado.Rows.Count == 1;
        }

        private bool ValidarNulo(String parametro)
        {
            return String.IsNullOrWhiteSpace(parametro);
        }

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxFechaNacimiento);
            seleccionarFecha.Show();
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                } 
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    } 
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    } 
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                } 
        }
    }
}
