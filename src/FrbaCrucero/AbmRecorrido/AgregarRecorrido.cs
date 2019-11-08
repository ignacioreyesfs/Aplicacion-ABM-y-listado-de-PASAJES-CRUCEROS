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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class AgregarRecorrido : Form
    {
        DataTable tablaTotal = new DataTable();
        ListadoRecorridoForm listadoRecorridos;
        List<Int32> tramosActuales = new List<Int32>();
        public AgregarRecorrido(ListadoRecorridoForm listadoRecorridos)
        {
            InitializeComponent();
            this.listadoRecorridos = listadoRecorridos;
            this.llenarDatos();  
        }

        private void llenarDatos()
        {
            Repositorios.RepoTramo.instancia.llenarDatos(dataGridViewTramosTotales);
            tablaTotal.Columns.Add("id", typeof(Int32));
            tablaTotal.Columns.Add("puertoDesde", typeof(String));
            tablaTotal.Columns.Add("puertoHasta", typeof(String));
            tablaTotal.Columns.Add("puertoDesdeDesc", typeof(String));
            tablaTotal.Columns.Add("puertoHastaDesc", typeof(String));
            tablaTotal.Columns.Add("precio_base", typeof(Double));
            dataGridViewTramosActuales.DataSource = tablaTotal;
            dataGridViewTramosActuales.Columns[1].Visible = false;
            dataGridViewTramosActuales.Columns[2].Visible = false;
            dataGridViewTramosActuales.Columns[3].Visible = false;
        }


        private void dataGridViewTramosTotales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Int32 idTramo = Int32.Parse(dataGridViewTramosTotales[1, e.RowIndex].Value.ToString());
                DataGridViewRow fila = dataGridViewTramosTotales.CurrentRow;
                this.agregarTramo(fila);
                this.tramosActuales.Add(idTramo);
                Repositorios.RepoTramo.instancia.actualizarDatosAgregar(tramosActuales, dataGridViewTramosTotales, fila.Cells[3].Value.ToString());
            }
        }

        private void dataGridViewTramosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex == dataGridViewTramosActuales.Rows.Count - 1)
                {
                    Int32 idTramo = Int32.Parse(dataGridViewTramosActuales[1, e.RowIndex].Value.ToString());
                    DataGridViewRow fila = dataGridViewTramosActuales.CurrentRow;
                    if (tablaTotal.Rows.Count == 1)
                    {
                        Repositorios.RepoTramo.instancia.llenarDatos(dataGridViewTramosTotales);
                    }
                    else
                    {
                        this.tramosActuales.Remove(idTramo);
                        Repositorios.RepoTramo.instancia.actualizarDatosQuitar(tramosActuales, dataGridViewTramosTotales, fila.Cells[2].Value.ToString());
                    }
                    this.quitarTramo(fila);
                }
            }
        }

        private void agregarTramo(DataGridViewRow fila)
        {
           var datarow = ((DataRowView)fila.DataBoundItem).Row;
           tablaTotal.Rows.Add(datarow.ItemArray);
        }

        private void quitarTramo(DataGridViewRow fila)
        {
            var datarow = ((DataRowView)fila.DataBoundItem).Row;
            tablaTotal.Rows.Remove(datarow);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (this.hayFilas())
            {
                String codigo = textBoxCodigo.Text;
                String idPuertoDesde = dataGridViewTramosActuales[2, 0].Value.ToString();
                Int32 indiceUltimaFila = dataGridViewTramosActuales.Rows.Count - 1;
                String idPuertoHasta = dataGridViewTramosActuales[3, indiceUltimaFila].Value.ToString();

                CrearRecorrido nuevoRecorrido = new CrearRecorrido(codigo, Int32.Parse(idPuertoDesde), Int32.Parse(idPuertoHasta));
                Int32 idRecorridoCreado = nuevoRecorrido.Crear();

                Int32 orden = 1;
                foreach (DataGridViewRow fila in dataGridViewTramosActuales.Rows)
                {
                    Int32 idTramo = Int32.Parse(fila.Cells[1].Value.ToString());
                    CrearRecorridoXTramo crearNuevoRecorridoXTramo = new CrearRecorridoXTramo(idRecorridoCreado, idTramo, orden);
                    crearNuevoRecorridoXTramo.Crear();
                    orden = orden + 1;
                }
                
                MessageBox.Show("Se ha ingresado el recorrido con exito.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                
                this.Close();
                listadoRecorridos.Buscar();
            }
            else
            {
                MessageBox.Show("No se puede crear un recorrido sin origen y destino.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool hayFilas()
        {
            return dataGridViewTramosActuales.Rows.Count != 0;
        }
  
    }
}
