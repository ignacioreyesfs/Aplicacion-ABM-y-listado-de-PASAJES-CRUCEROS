using FrbaCrucero.Modelos;
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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class ListadoCruceros : Form
    {
        FormGenerarViaje formulario;
        public ListadoCruceros(FormGenerarViaje formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void limpiarFiltros()
        {
            textBoxCrucero.Clear();
            comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact("");
        }

        public void buscar()
        {
            string valorDescripcion = (!String.IsNullOrEmpty(textBoxCrucero.Text)) ? textBoxCrucero.Text.Trim() : "";
            string textEstado = Convert.ToString(comboBoxEstado.SelectedItem);
            Int16? valorFueraServicio = null;
            string textModelo = textBoxModelo.Text.Trim();
            string textServicio = Convert.ToString(comboBoxServicio.SelectedItem);

            if (textEstado.Equals("En servicio"))
                valorFueraServicio = (Int16)0;
            if (textEstado.Equals("Fuera de servicio"))
                valorFueraServicio = (Int16)1;


            List<Crucero> cruceros = RepoCrucero.instancia.EncontrarCruceroNombreEstadoModeloServicio(valorDescripcion, valorFueraServicio, textModelo, textServicio);
            this.dataGridViewCrucero.DataSource = cruceros;

            this.dataGridViewCrucero.Columns["nombre"].HeaderText = "Nombre";
            this.dataGridViewCrucero.Columns["modelo"].HeaderText = "Modelo";
            this.dataGridViewCrucero.Columns["tipo_servicio"].HeaderText = "Tipo de servicio";
            this.dataGridViewCrucero.Columns["fecha_reinicio_servicio"].HeaderText = "Fecha reinicio servicio";
            this.dataGridViewCrucero.Columns["cant_cabinas"].HeaderText = "Cantidad de cabinas";
            dataGridViewCrucero.MultiSelect = false;
            dataGridViewCrucero.Columns["id"].Visible = false;
        }

        private void dataGridViewCrucero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String id = dataGridViewCrucero[1, e.RowIndex].Value.ToString();
                formulario.textBoxCrucero.Text = id;
                this.Close();
            }
        }
    }
}
