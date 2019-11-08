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

namespace FrbaCrucero.AbmRol
{
    public partial class ListadoRolesForm : Form
    {
        public ListadoRolesForm()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        public void buttonBuscar_Click(object sender, EventArgs e)
        {
            string valorDescripcion = (!String.IsNullOrEmpty(textBoxRol.Text)) ? textBoxRol.Text.Trim() : "";
            string textHabilitado = Convert.ToString(comboBoxHabilitado.SelectedItem);
            Boolean hayValorHabilitado = false;
            Int16 valorHabilitado = 0;

            if (!String.IsNullOrWhiteSpace(textHabilitado))
            {
                hayValorHabilitado = true;
                valorHabilitado = (textHabilitado.Equals("Si")) ? (Int16)1 : (Int16)0;
            }

            List<Rol> roles = RepoRol.instancia.EncontrarPorDescripcionYHabilitado(valorDescripcion, valorHabilitado, hayValorHabilitado);
            dataGridViewRoles.DataSource = roles;
            dataGridViewRoles.Columns["id"].Visible = false;
            dataGridViewRoles.MultiSelect = false;
        }

        private void limpiarFiltros()
        {
            textBoxRol.Clear();
            comboBoxHabilitado.SelectedIndex = comboBoxHabilitado.FindStringExact("");
            dataGridViewRoles.DataSource = null;
        }

        private void dataGridViewRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Rol rol = (Rol)dataGridViewRoles.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == 1)
            {
                this.modificarRol(rol);
            }

            if (e.ColumnIndex == 0)
            {
                this.eliminarRol(rol);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Rol nuevoRol = new Rol();
            Form rolForm = new RolForm(nuevoRol, this);
            rolForm.MdiParent = this.MdiParent;
            rolForm.Show();
        }

        private void modificarRol(Rol rol)
        {
            
            Form rolForm = new RolForm(rol, this);
            rolForm.MdiParent = this.MdiParent;
            rolForm.Show();
        }

        private void eliminarRol(Rol rol)
        {
            string texto = "Estás seguro de eliminar rol: " + rol.descripcion + ".";
            DialogResult dr = MessageBox.Show(
                texto, 
                "Eliminación rol", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                RepoRol.instancia.DeshabilitarRol(rol.id);
                buttonLimpiar_Click(null, null);
            }

        }
    }
}
