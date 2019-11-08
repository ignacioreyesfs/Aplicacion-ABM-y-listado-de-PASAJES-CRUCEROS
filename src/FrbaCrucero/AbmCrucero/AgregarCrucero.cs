using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class AgregarCrucero : Form
    {
        public ListadoCrucerosForm listadoCruceros;
        public TextBox textBoxParam;
        public AgregarCrucero(ListadoCrucerosForm listadoCruceros)
        {
            InitializeComponent();
            this.listadoCruceros = listadoCruceros;
            this.textBoxFabricante.ReadOnly = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombre.Text;
            String modelo = textBoxModelo.Text;
            String fabricante = textBoxFabricante.Text;
            DateTime fecha_alta = DateTime.Now;
            String tipo_servicio = comboBoxTipoServicio.Text;
            Int32? cantidad_cabinas = Decimal.ToInt32(numericUpDownCantidadCabinas.Value);

            this.IngresarParametros(nombre, fecha_alta, modelo, fabricante, tipo_servicio, cantidad_cabinas);
        }


        private void IngresarParametros(String nombre, DateTime fecha_alta, String modelo, String fabricante, String tipo_servicio, Int32? cantidad_cabinas)
        {
            Dictionary<String, String> parametrosObligatorios = new Dictionary<String, String>();
            parametrosObligatorios.Add("nombre", nombre);
            parametrosObligatorios.Add("modelo", modelo);
            parametrosObligatorios.Add("fabricante", fabricante);
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
                CrearCrucero nuevoCrucero = new CrearCrucero(nombre, fecha_alta, modelo, fabricante, tipo_servicio, cantidad_cabinas);

                nuevoCrucero.Crear();
                listadoCruceros.buscar();
                this.Close();
            }
        }

        private bool ValidarNulo(String parametro)
        {
            return String.IsNullOrWhiteSpace(parametro);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionarFabricante_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFabricante;
            SeleccionarFabricante seleccionarFabricante = new SeleccionarFabricante(this, textBoxParam);
            seleccionarFabricante.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNombre.Text = null;
            this.textBoxModelo.Text = null;
            this.textBoxFabricante.Text = null;
            this.numericUpDownCantidadCabinas.Value = 0;
            this.comboBoxTipoServicio.Text = null;
        }

    }
}
