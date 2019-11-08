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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class FormGenerarViaje : Form
    {
        public TextBox textBoxParam;
        public FormGenerarViaje()
        {
            InitializeComponent();
            textBoxCrucero.ReadOnly = true;
            textBoxIDRecorrido.ReadOnly = true;
            textBoxFechaInicio.ReadOnly = true;
            textBoxFechaFin.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }

        private void buttonSeleccionarCrucero_Click(object sender, EventArgs e)
        {
            ListadoCruceros listadoCruceros = new ListadoCruceros(this);
            listadoCruceros.Show();
        }

        private void buttonSeleccionarFechaInicio_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaInicio;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(this, textBoxParam);
            seleccionarFecha.MdiParent = this.MdiParent;
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaFin_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaFin;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(this, textBoxParam);
            seleccionarFecha.MdiParent = this.MdiParent;
            seleccionarFecha.Show();
        }

        private void buttonGenerarViaje_Click(object sender, EventArgs e)
        {
            String idCrucero = textBoxCrucero.Text;
            String idRecorrido = textBoxIDRecorrido.Text;
            String fecha_inicio = textBoxFechaInicio.Text;
            String fecha_fin = textBoxFechaFin.Text;

            Dictionary<String, String> parametrosObligatorios = new Dictionary<String, String>();
            parametrosObligatorios.Add("Crucero", idCrucero);
            parametrosObligatorios.Add("Recorrido", idRecorrido);
            parametrosObligatorios.Add("Fecha inicio", fecha_inicio);
            parametrosObligatorios.Add("Fecha fin", fecha_fin);
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
                CrearViaje crearViaje = new CrearViaje(Int32.Parse(idCrucero), 
                                                       Int32.Parse(idRecorrido), 
                                                       Convert.ToDateTime(fecha_inicio), 
                                                       Convert.ToDateTime(fecha_fin));
                crearViaje.Crear();
            }          
        }

        private bool ValidarNulo(String parametro)
        {
            return String.IsNullOrWhiteSpace(parametro);
        }

        private void buttonSeleccionarPuertoHasta_Click(object sender, EventArgs e)
        {
            ListadoRecorrido listadoRecorrido = new ListadoRecorrido(this);
            listadoRecorrido.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDRecorrido.Text = null;
            textBoxCrucero.Text = null;
            textBoxFechaFin.Text = null;
            textBoxFechaInicio.Text = null;
        }
    }
}
