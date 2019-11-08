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

namespace FrbaCrucero.AbmCrucero
{
    public partial class SeleccionarFabricante : Form
    {
        AgregarCrucero form;
        TextBox textBoxParam;

        public SeleccionarFabricante(AgregarCrucero form, TextBox textBoxParam)
        {
            InitializeComponent();
            this.form = form;
            this.textBoxParam = textBoxParam;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string descripcionFabricante = textBoxFabricante.Text;
            List<Fabricante> fabricantes = RepoFabricante.instancia.EncontrarPorDescripcionFabricante(descripcionFabricante);
            dataGridViewFabricantes.DataSource = fabricantes;
        }

        private void dataGridViewFabricantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                form.textBoxParam.Text = dataGridViewFabricantes[1, e.RowIndex].Value.ToString();
        }
    }
}
