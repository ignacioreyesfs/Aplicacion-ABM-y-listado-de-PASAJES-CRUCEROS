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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ListadoRecorridoForm : Form
    {
        public TextBox textBoxParam;
        public ListadoRecorridoForm()
        {
            InitializeComponent();
            textBoxPuertoDesde.ReadOnly = true;
            textBoxPuertoHasta.ReadOnly = true;
            comboBoxHabilitado.SelectedIndex = 0;
            dataGridViewRecorrido.ReadOnly = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPuertoDesde.Text = null;
            textBoxPuertoHasta.Text = null;
            comboBoxHabilitado.Text = "Todos";
        }

        private void buttonSeleccionarDesde_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxPuertoDesde;
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(this, textBoxParam);
            seleccionarPuerto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxParam = textBoxPuertoHasta;
            SeleccionarPuerto seleccionarPuerto = new SeleccionarPuerto(this, textBoxParam);
            seleccionarPuerto.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarRecorrido agregarRecorrido = new AgregarRecorrido(this);
            agregarRecorrido.Show();
        }

        public void Buscar()
        {
            string valorPuertoDesde = textBoxPuertoDesde.Text;
            string valorPuertoHasta = textBoxPuertoHasta.Text;
            string textHabilitado = Convert.ToString(comboBoxHabilitado.SelectedItem);
            Int16? valorHabilitado = null;

            if (!textHabilitado.Equals("Todos"))
            {
                valorHabilitado = (textHabilitado.Equals("Si")) ? (Int16)1 : (Int16)0;
            }

            List<Recorrido> recorridos = RepoRecorrido.instancia
                                                 .EncontrarPorParametros(valorPuertoDesde, valorPuertoHasta, valorHabilitado);
            dataGridViewRecorrido.DataSource = recorridos;
            dataGridViewRecorrido.MultiSelect = false;
            dataGridViewRecorrido.Columns["id"].Visible = false;
            this.actualizarRecorridos();
        }

        private void actualizarRecorridos()
        {
            String sqlQuery = "FGNN_19.P_Actualizar_Recorridos";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        private void dataGridViewRecorrido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 id = Int32.Parse(dataGridViewRecorrido[2, e.RowIndex].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                String codigo = dataGridViewRecorrido[3, e.RowIndex].Value.ToString();
                ModificarRecorrido modificarRecorrido = new ModificarRecorrido(this, id, codigo);
                modificarRecorrido.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                Int32 tieneViajes = this.tieneViaje(id);
                if (tieneViajes == 1)
                {
                    MessageBox.Show("El recorrido no puede darse de baja ya que tiene viajes pendientes.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Buscar();
                }
                else
                {
                    MessageBox.Show("Se ha dado de baja el recorrido correctamente.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.bajaRecorrido(id);
                    this.Buscar();
                }

            }
        }

        private Int32 tieneViaje(Int32 idRecorrido)
        {
            String sqlQuery = "FGNN_19.P_Verificar_Recorrido";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            String fechaHoy = ConfigurationManager.AppSettings["Date"];
            cmd.Parameters.Add(new SqlParameter("fechaHoy", fechaHoy));
            DataTable resultado = ConexionDB.instancia.obtenerData(cmd);
            if (resultado.Rows.Count != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            } 
        }

        private void bajaRecorrido(Int32 idRecorrido)
        {
            String sqlQuery = "UPDATE FGNN_19.Recorridos SET habilitado = 0 WHERE id = @idRecorrido";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.Add(new SqlParameter("idRecorrido", idRecorrido));
            ConexionDB.instancia.ejecutarQuery(cmd);
        }


    }
}
