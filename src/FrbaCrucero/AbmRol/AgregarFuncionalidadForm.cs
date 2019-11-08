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

namespace FrbaCrucero.AbmRol
{
    public partial class FormAgregarFuncionalidad : Form
    {
        RolForm father;

        public FormAgregarFuncionalidad(List<Funcionalidad> funcionalidades, RolForm father)
        {
            InitializeComponent();
            comboBoxFuncionalidades.DataSource = funcionalidades;
            comboBoxFuncionalidades.DisplayMember = "descripcion";
            comboBoxFuncionalidades.ValueMember = "id";

            this.father = father;  
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidad = (Funcionalidad) comboBoxFuncionalidades.SelectedItem;
            father.AgregarFuncionalidad(funcionalidad);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            father.ControlBox = true;
        }
    }
}
