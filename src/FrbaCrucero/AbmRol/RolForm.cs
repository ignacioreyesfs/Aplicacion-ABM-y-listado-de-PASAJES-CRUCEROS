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
    public partial class RolForm : Form
    {
        private Rol rol;
        private ListadoRolesForm formPadre;

        public RolForm(Rol rol, ListadoRolesForm form)
        {
            InitializeComponent();
            this.rol = rol;
            this.formPadre = form;
            textBoxDescripcion.Text = rol.descripcion;
            checkBoxHabilitado.Checked = (rol.habilitado == 1) ? true : false;
            dataGridViewFuncionalidades.DataSource = rol.GetFuncionalidades();
            dataGridViewFuncionalidades.Columns["id"].Visible = false;
            dataGridViewFuncionalidades.Columns["descripcion"].HeaderText = "Funcionalidad";
            dataGridViewFuncionalidades.MultiSelect = false;
        }

        public void AgregarFuncionalidad(Funcionalidad funcionalidad)
        {
            rol.AgregarFuncionalidad(funcionalidad);
            refresDataGridView();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formPadre.buttonBuscar_Click(null, null);
        }

        private void buttonEliminarFunc_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadAEliminar = (Funcionalidad)dataGridViewFuncionalidades.CurrentRow.DataBoundItem;
            rol.funcionalidades = rol.GetFuncionalidades().Where(f => f.id != funcionalidadAEliminar.id).ToList();
            refresDataGridView();
        }

        private void buttonAgregarFunc_Click(object sender, EventArgs e)
        {
            List<Funcionalidad> todasFunc = RepoFuncionalidad.instancia.EncontrarTodos();
            List<Funcionalidad> rolFun = rol.GetFuncionalidades();
            List<Funcionalidad> faltantesFunc = todasFunc.Where(p => !rolFun.Any(l => p.id == l.id)).ToList();

            Form agregarFuncionalidad = new FormAgregarFuncionalidad(faltantesFunc, this);
            agregarFuncionalidad.MdiParent = this.MdiParent;
            agregarFuncionalidad.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            rol.descripcion = textBoxDescripcion.Text;
            rol.habilitado = (checkBoxHabilitado.Checked) ? Convert.ToInt16(1) : Convert.ToInt16(0);

            if (IsValido(rol))
            {
                if (!rol.id.Equals(0))
                {
                    Dictionary<string, object> paramentrosAModificar = new Dictionary<string, object>();
                    paramentrosAModificar.Add("descripcion", rol.descripcion);
                    RepoRol.instancia.Modificar(rol.id, paramentrosAModificar);
                }
                else
                {
                    rol.id = RepoRol.instancia.Crear(rol);
                }
                

                if (rol.funcionalidades.Any())
                {
                    RepoRol.instancia.ActualizarFuncinalidades(rol);
                }

                if (!checkBoxHabilitado.Checked)
                {
                    RepoRol.instancia.DeshabilitarRol(rol.id);
                }
                else
                {
                    RepoRol.instancia.HabilitarRol(rol.id);
                }
                
                formPadre.buttonBuscar_Click(null, null);
                this.Close();
            }
        }

        private void RolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool sePuedeCerrar = true;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Agregar Funcionalidad")
                {
                    sePuedeCerrar = false;
                    f.BringToFront();
                }
            }

            if (!sePuedeCerrar)
            {
                e.Cancel = true;
            }

        }

        private void refresDataGridView()
        {
            dataGridViewFuncionalidades.DataSource = null;
            dataGridViewFuncionalidades.DataSource = rol.GetFuncionalidades();
            dataGridViewFuncionalidades.Columns["id"].Visible = false;
            dataGridViewFuncionalidades.Columns["descripcion"].HeaderText = "Funcionalidad";
            dataGridViewFuncionalidades.MultiSelect = false;
        }

        private Boolean IsValido(Rol rol)
        {
            List<string> errores = new List<string>();

            if(String.IsNullOrEmpty(rol.descripcion))
            {
                errores.Add("Nombre: El campo no puede estar vacio.");
            }


            if (errores.Any())
            {
                StringBuilder stringBuileder = new StringBuilder();
                foreach (string error in errores)
                {
                    stringBuileder.Append(error).Append("\n");
                }
                MessageBox.Show(stringBuileder.ToString(), "Error en Rol",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
