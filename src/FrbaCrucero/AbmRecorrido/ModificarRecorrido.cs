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
    public partial class ModificarRecorrido : Form
    {
        DataTable tablaTotal = new DataTable();
        Int32 idRecorrido;
        String codigoRecorrido;
        ListadoRecorridoForm listado;
        List<Int32> tramosQuitadosRecorridoOriginal = new List<Int32>();
        List<Int32> tramosActuales = new List<Int32>();
        public ModificarRecorrido(ListadoRecorridoForm listado, Int32 idRecorrido, String codigoRecorrido)
        {
            InitializeComponent();
            this.listado = listado;
            this.idRecorrido = idRecorrido;
            this.codigoRecorrido = codigoRecorrido;
            this.textBoxCodigo.Text = codigoRecorrido;
            Repositorios.RepoTramo.instancia.llenarDatos(dataGridViewTramosTotales);
            tablaTotal.Columns.Add("id", typeof(Int32));
            tablaTotal.Columns.Add("puertoDesde", typeof(String));
            tablaTotal.Columns.Add("puertoHasta", typeof(String));
            tablaTotal.Columns.Add("puertoDesdeDesc", typeof(String));
            tablaTotal.Columns.Add("puertoHastaDesc", typeof(String));
            tablaTotal.Columns.Add("precio_base", typeof(Double));
            tablaTotal = Repositorios.RepoTramo.instancia.tramosActuales(dataGridViewTramosActuales, idRecorrido, tablaTotal);
            dataGridViewTramosActuales.DataSource = tablaTotal;
            dataGridViewTramosActuales.Columns[1].Visible = false;
            dataGridViewTramosActuales.Columns[2].Visible = false;
            dataGridViewTramosActuales.Columns[3].Visible = false;
            this.actualizarTramosActuales();
            this.llenarListaActual();
        }

        private void llenarListaActual()
        {
            foreach (DataGridViewRow fila in dataGridViewTramosActuales.Rows)
            {
                tramosActuales.Add(Int32.Parse(fila.Cells[1].Value.ToString()));
            }
        }

        private void actualizarTramosActuales()
        {
            Int32 indiceUltimaFila = dataGridViewTramosActuales.Rows.Count - 1;
            DataGridViewRow fila = dataGridViewTramosActuales.Rows[indiceUltimaFila];
            Repositorios.RepoTramo.instancia.actualizarDatos(dataGridViewTramosTotales, fila.Cells[3].Value.ToString());
        }

        private void dataGridViewTramosTotales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Int32 idTramo = Int32.Parse(dataGridViewTramosTotales[1, e.RowIndex].Value.ToString());
                this.validarTramoAgregado(idTramo);
                DataGridViewRow fila = dataGridViewTramosTotales.CurrentRow;
                this.agregarTramo(fila);
                this.tramosActuales.Add(idTramo);
                Repositorios.RepoTramo.instancia.actualizarDatosAgregar(tramosActuales, dataGridViewTramosTotales, fila.Cells[3].Value.ToString());
            }
        }

        private void validarTramoAgregado(Int32 idTramo)
        {
            if (tramosQuitadosRecorridoOriginal.Contains(idTramo))
            {
                tramosQuitadosRecorridoOriginal.Remove(idTramo);
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
                    this.validarTramoQuitado(idTramo);
                    this.quitarTramo(fila);
                }
            }
        }

        private void validarTramoQuitado(Int32 idTramo)
        {
            if (this.tramoRecorridoOriginal(idTramo))
            {
                tramosQuitadosRecorridoOriginal.Add(idTramo);
            }
        }

        private bool tramoRecorridoOriginal(Int32 id)
        {
            return Repositorios.RepoTramo.instancia.tramoRecorridoOriginal(id, idRecorrido);
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
                Int32 idPuertoDesde = Int32.Parse(dataGridViewTramosActuales[2, 0].Value.ToString());
                Int32 indiceUltimaFila = dataGridViewTramosActuales.Rows.Count - 1;
                Int32 idPuertoHasta = Int32.Parse(dataGridViewTramosActuales[3, indiceUltimaFila].Value.ToString());
                Dictionary<String, object> parametros = new Dictionary<String, object>();
                parametros.Add("codigo", codigo);
                parametros.Add("puerto_desde_id", idPuertoDesde);
                parametros.Add("puerto_hasta_id", idPuertoHasta);
                Repositorios.RepoRecorrido.instancia.Modificar(idRecorrido, parametros);

                foreach (Int32 idTramo in tramosQuitadosRecorridoOriginal)
                {
                    Repositorios.RepoTramo.instancia.eliminarTramo(idRecorrido, idTramo);
                }

                Repositorios.RepoTramo.instancia.vaciarRegistro(idRecorrido);

                Int32 orden = 1;
                foreach (DataGridViewRow fila in dataGridViewTramosActuales.Rows)
                {
                    Int32 idTramo = Int32.Parse(fila.Cells[1].Value.ToString());
                    CrearRecorridoXTramo crearNuevoRecorridoXTramo = new CrearRecorridoXTramo(idRecorrido, idTramo, orden);
                    crearNuevoRecorridoXTramo.Crear();
                    orden = orden + 1;
                }

                MessageBox.Show("Se ha modificado el recorrido con exito.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Close();
                listado.Buscar();
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
