using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class ListadoCrucerosForm : Form
    {
        public ListadoCrucerosForm()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void limpiarFiltros()
        {
            textBoxCrucero.Clear();
            comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact("");
        }

        private void dataGridViewCrucero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                String id = dataGridViewCrucero[2, e.RowIndex].Value.ToString();
                int fila = e.RowIndex;
                DataGridView tablaCruceros = dataGridViewCrucero;
                ModificarCrucero modificarCrucero = new ModificarCrucero(this, id, tablaCruceros, fila);
                modificarCrucero.Show();
            }
            else if(e.ColumnIndex == 1)
            {
                String id = dataGridViewCrucero[2, e.RowIndex].Value.ToString();
                BajaCrucero bajaCrucero = new BajaCrucero(this, Int32.Parse(id));
                bajaCrucero.Show();
            }
        }

        public void buscar()
        {
            this.actualizarCruceros();

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

        private void actualizarCruceros()
        {
            String sqlQuery = "FGNN_19.Actualizacion_reinicio_cruceros";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarCrucero agregarCrucero = new AgregarCrucero(this);
            agregarCrucero.Show();
        }
    }
}
