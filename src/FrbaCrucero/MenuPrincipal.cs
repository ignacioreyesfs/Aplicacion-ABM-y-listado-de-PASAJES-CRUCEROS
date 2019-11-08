using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmRol;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.Modelos;
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.CompraPasaje;
using FrbaCrucero.PagoReserva;

namespace FrbaCrucero
{
    public partial class MenuPrincipalForm : Form
    {


        public MenuPrincipalForm(Rol rol)
        {
            InitializeComponent();
            mostrarMenuPrincipalPorRol(rol);
        }

        public MenuPrincipalForm()
        {
            InitializeComponent();
            mostrarMenuPrincipalCliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoRolesForm listadoRoles = new ListadoRolesForm();
            listadoRoles.MdiParent = this;
            listadoRoles.Show();
        }
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormGenerarViaje generarViaje = new FormGenerarViaje();
            generarViaje.MdiParent = this;
            generarViaje.Show();
        }

  
        
        private void mostrarMenuPrincipalPorRol(Rol rol)
        {
            Dictionary<string, ToolStripLabel> funcLabelBarra = new Dictionary<string, ToolStripLabel>();
            funcLabelBarra.Add("ABM Roles", toolStripLabelABM);
            funcLabelBarra.Add("ABM Recorridos", toolStripCompreReserva);

            foreach (Funcionalidad func in rol.GetFuncionalidades())
                if (!funcLabelBarra.ContainsKey(func.descripcion))
                {
                    //funcLabelBarra[func.descripcion].Visible = false;
                }
        }

        private void mostrarMenuPrincipalCliente()
        {
            toolStripLabelABM.Visible = false;
            toolStripLabelRecorrido.Visible = false;
            toolStripLabelGenerarViaje.Visible = false;
            toolStripLabelCrucero.Visible = false;
            toolStripSeparator2.Visible = false;
            toolStripSeparator1.Visible = false;
            toolStripSeparator3.Visible = false;
            toolStripSeparator4.Visible = false;
            toolStripSeparator6.Visible = false;
            toolStripLabelTop.Visible = false; 
        }

        private void toolStripLabelGenerarViaje_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormGenerarViaje generarViaje = new FormGenerarViaje();
            generarViaje.MdiParent = this;
            generarViaje.Show();
        }

        private void toolStripLabelCrucero_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoCrucerosForm listadoCruceros = new ListadoCrucerosForm();
            listadoCruceros.MdiParent = this;
            listadoCruceros.Show();
        }

        private void toolStripCompreReserva_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            CompraReservaPasajeForm compraReservaPasaje = new CompraReservaPasajeForm();
            compraReservaPasaje.MdiParent = this;
            compraReservaPasaje.Show();
        }

        private void toolStripLabelRecorrido_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoRecorridoForm listadoRecorrido = new ListadoRecorridoForm();
            listadoRecorrido.MdiParent = this;
            listadoRecorrido.Show();
        }

        private void toolStripLabelTopPasaje_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ListadoEstadisticoForm recorridosConMasPasajes = new ListadoEstadisticoForm();
            recorridosConMasPasajes.MdiParent = this;
            recorridosConMasPasajes.Show();
        }

        private void toolStripPagoReserva_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            SeleccionarReservaForm reservaForm = new SeleccionarReservaForm();
            reservaForm.MdiParent = this;
            reservaForm.Show();
        }
    }
}
