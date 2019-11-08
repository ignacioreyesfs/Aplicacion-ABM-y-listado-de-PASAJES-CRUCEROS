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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class SeleccionarCabina : Form
    {
        DataTable tablaTotal = new DataTable();
        Int32 idCrucero;
        CrearPasaje pasaje;
        public SeleccionarCabina(Int32 idCrucero, CrearPasaje pasaje)
        {
            InitializeComponent();
            this.idCrucero = idCrucero;
            this.pasaje = pasaje;
            this.llenarDatos();
        }

        private void llenarDatos()
        {
            tablaTotal = Repositorios.RepoCrucero.instancia.cabinasDisponibles(dataGridViewCabinas, idCrucero, tablaTotal);
            dataGridViewCabinas.DataSource = tablaTotal;
            this.dataGridViewCabinas.Columns[1].Visible = false;
        }

        private void dataGridViewCabinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Int32 idCabina = Int32.Parse(dataGridViewCabinas[1, e.RowIndex].Value.ToString());
                pasaje.cabina_id = idCabina;
                SeleccionarPasajeros seleccionarPasajeros = new SeleccionarPasajeros(pasaje);
                seleccionarPasajeros.Show();
                this.Close();
            }
        }
    }
}
