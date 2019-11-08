using FrbaCrucero.Repositorios;
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
    public partial class ModificarCrucero : Form
    {
        public ListadoCrucerosForm listadoCruceros;
        public int filaSeleccionada;
        public DataGridView tablaCruceros;
        public TextBox textBoxParam;
        public ModificarCrucero(ListadoCrucerosForm listadoCruceros, String ID, DataGridView tablaCruceros, int filaSeleccionada)
        {
            InitializeComponent();
            this.listadoCruceros = listadoCruceros;
            textBoxFechaBajaDefinitiva.ReadOnly = true;
            textBoxFechaFueraServicio.ReadOnly = true;
            textBoxFechaReinicioServicio.ReadOnly = true;
            textBoxID.ReadOnly = true;
            textBoxID.Text = ID;
            ingresarParametroTB(textBoxNombre, tablaCruceros, 3, filaSeleccionada);
            ingresarParametroTB(textBoxModelo, tablaCruceros, 5, filaSeleccionada);
            ingresarParametroCB(comboBoxTipoServicio, tablaCruceros, 7, filaSeleccionada);
            ingresarParametroCB(comboBoxBajaServicio, tablaCruceros, 8, filaSeleccionada);
            ingresarParametroTB(textBoxFechaFueraServicio, tablaCruceros, 10, filaSeleccionada);
            ingresarParametroTB(textBoxFechaReinicioServicio, tablaCruceros, 11, filaSeleccionada);
            ingresarParametroTB(textBoxFechaBajaDefinitiva, tablaCruceros, 12, filaSeleccionada);
            ingresarParametroNUD(numericUpDownCantidadCabinas, tablaCruceros, 13, filaSeleccionada);

        }

        private void buttonSeleccionarFechaFueraServicio_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaFueraServicio;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxParam);
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaReinicioServicio_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaReinicioServicio;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxParam);
            seleccionarFecha.Show();
        }

        private void buttonSeleccionarFechaBajaDefinitiva_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxFechaBajaDefinitiva;
            SeleccionarFecha seleccionarFecha = new SeleccionarFecha(textBoxParam);
            seleccionarFecha.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxTipoServicio.Text = null;
            textBoxFechaFueraServicio.Text = null;
            textBoxFechaBajaDefinitiva.Text = null;
            textBoxFechaReinicioServicio.Text = null;
            numericUpDownCantidadCabinas.Value = 0;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> paramentrosAModificar = new Dictionary<string,object>();

            ingresarValor(paramentrosAModificar, "nombre", textBoxNombre.Text);
            ingresarValor(paramentrosAModificar, "modelo", textBoxModelo.Text);
            ingresarValorConNulos(paramentrosAModificar, "tipo_servicio", comboBoxTipoServicio.Text);
            paramentrosAModificar.Add("baja_servicio", comboBoxBajaServicio.Text);
            ingresarValorConNulos(paramentrosAModificar, "fecha_fuera_servicio", textBoxFechaFueraServicio.Text);
            ingresarValorConNulos(paramentrosAModificar, "fecha_reinicio_servicio", textBoxFechaReinicioServicio.Text);
            ingresarValorConNulos(paramentrosAModificar, "fecha_baja_definitiva", textBoxFechaBajaDefinitiva.Text);
            ingresarCantidadCabinas(paramentrosAModificar, "cant_cabinas", numericUpDownCantidadCabinas.Value);

            RepoCrucero.instancia.Modificar(Int32.Parse(textBoxID.Text), paramentrosAModificar);
            this.Close();
            listadoCruceros.buscar();
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarValorConNulos(Dictionary<string, object> listaParametros, String nombre, String valor)
        {
            if (!String.IsNullOrWhiteSpace(valor))
            {
                listaParametros.Add(nombre, valor);
            }
            else
            {
                listaParametros.Add(nombre, DBNull.Value);
            }
                
        }

        private void ingresarCantidadCabinas(Dictionary<string, object> listaParametros, String nombre, Decimal valor)
        {
            if (valor != 0)
            {
                listaParametros.Add(nombre, valor.ToString());
            }
            else
            {
                listaParametros.Add(nombre, DBNull.Value);
            }
        }

        private void ingresarValor(Dictionary<string, object> listaParametros, String nombre, String valor)
        {
            if (!String.IsNullOrWhiteSpace(valor))
            {
                listaParametros.Add(nombre, valor);
            }
            else
            {
                MessageBox.Show("No se puede dejar el campo " + nombre + " vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ingresarParametroTB(TextBox textBox, DataGridView tabla, int columna, int fila)
        {
            if (tabla[columna, fila].Value != null)
            {
                textBox.Text = tabla[columna, fila].Value.ToString();
            }
            else
            {
                textBox.Text = null;
            }
        }

        private void ingresarParametroCB(ComboBox comboBox, DataGridView tabla, int columna, int fila)
        {
            if (tabla[columna, fila].Value != null)
            {
                comboBox.Text = tabla[columna, fila].Value.ToString();
            }
            else
            {
                comboBox.Text = null;
            }
        }

        private void ingresarParametroNUD(NumericUpDown numericUD, DataGridView tabla, int columna, int fila)
        {
            if (tabla[columna, fila].Value != null)
            {
                numericUD.Value = Int32.Parse(tabla[columna, fila].Value.ToString());
            }
            else
            {
                numericUD.Value = 1;
            }
        }

    }
}
