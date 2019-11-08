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
    public partial class SeleccionarPasajeros : Form
    {
        CrearPasaje pasaje;
        public SeleccionarPasajeros(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
            this.numericUpDownPasajeros.ReadOnly = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            pasaje.pasajeros = Int32.Parse(numericUpDownPasajeros.Value.ToString());
            CompletarDatosCliente completarDatosCliente = new CompletarDatosCliente(pasaje);
            completarDatosCliente.Show();
            this.Close();
        }
    }
}
