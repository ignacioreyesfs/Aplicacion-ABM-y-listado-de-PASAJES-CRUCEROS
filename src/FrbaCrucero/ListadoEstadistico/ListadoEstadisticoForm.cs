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

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {

        private List<string> semestres = new List<string> { "Seleccione un semestre", "Primer semestre", "Segundo semestre" };
        private CrucerosSinServicio crucerosSinServicio;
        private RecorridosConMasCabinas recorridosConMasCabinas;
        private RecorridosConMasPasajes recorridosConMasPasajes;

        public ListadoEstadisticoForm()
        {
            crucerosSinServicio = new CrucerosSinServicio(this);
            recorridosConMasCabinas = new RecorridosConMasCabinas(this);
            recorridosConMasPasajes = new RecorridosConMasPasajes(this);
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            this.initialize();
        }

        private void initialize() 
        {
            this.comboSemestre.Enabled = true;
            this.comboSemestre.DataSource = semestres;
        }

        private void buttonRecorridosMasPasajes_Click(object sender, EventArgs e)
        {
            string semestre = (string)comboSemestre.SelectedItem;
            string anio = dateTimePicker1.Value.ToString("yyyy");
            if (anio.Equals("Seleccione un año") || semestre.Equals("Seleccione un semestre"))
            {
                showErrorMessage("Seleccione los filtros correctamente.");
            }
            else
            {
                //limpiarButton.Enabled = false;
                resultadosTop5Grid.DataSource = null;
                //comboSemestre.Enabled = false;
                this.recorridosConMasPasajes.GetRecorridosConFiltros(anio, semestre);
            }
        }

        public void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void showInformationMessage(string message)
        {
            MessageBox.Show(message, "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void showRecorridos(ShowListado resultados)
        {
            this.limpiarButton.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.comboSemestre.Enabled = true;

            switch (resultados.Descripcion)
            {
                case 1:
                    this.resultadosTop5Grid.DataSource = resultados.Listado.Select(
                resultado => new
                {
                    PuertoSalida = resultado.PrimeraColumna,
                    PuertoLlegada = resultado.SegundaColumna,
                    CantidadDePasajes = resultado.TerceraColumna
                }
            ).ToList();
                    break;
                case 2:
                    this.resultadosTop5Grid.DataSource = resultados.Listado.Select(
                resultado => new
                {
                    PuertoSalida = resultado.PrimeraColumna,
                    PuertoLlegada = resultado.SegundaColumna,
                    CantidadDeCabinas = resultado.TerceraColumna
                }
            ).ToList();
                    break;
                case 3:
                    this.resultadosTop5Grid.DataSource = resultados.Listado.Select(
                resultado => new
                {
                    Nombre = resultado.PrimeraColumna,
                    Modelo = resultado.SegundaColumna,
                    CantidadDeCruceros = resultado.TerceraColumna
                }
            ).ToList();
                    break;
            }

            
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            comboSemestre.SelectedItem = semestres[0];
            resultadosTop5Grid.DataSource = null;
        }

        private void buttonRecorridosMasCabinasLibres_Click(object sender, EventArgs e)
        {
            string semestre = (string)comboSemestre.SelectedItem;
            string anio = dateTimePicker1.Value.ToString("yyyy");
            if (anio.Equals("Seleccione un año") || semestre.Equals("Seleccione un semestre"))
            {
                showErrorMessage("Seleccione los filtros correctamente.");
            }
            else
            {
                //limpiarButton.Enabled = false;
                resultadosTop5Grid.DataSource = null;
                //comboSemestre.Enabled = false;
                this.recorridosConMasCabinas.GetRecorridosConFiltros(anio, semestre);
            }
        }

        private void buttonCrucerosDiasSinServicio_Click(object sender, EventArgs e)
        {
            string semestre = (string)comboSemestre.SelectedItem;
            string anio = dateTimePicker1.Value.ToString("yyyy");
            if (anio.Equals("Seleccione un año") || semestre.Equals("Seleccione un semestre"))
            {
                showErrorMessage("Seleccione los filtros correctamente.");
            }
            else
            {
                //limpiarButton.Enabled = false;
                resultadosTop5Grid.DataSource = null;
                //comboSemestre.Enabled = false;
                this.crucerosSinServicio.GetCrucerosConFiltros(anio, semestre);
            }
        }
    }
}
