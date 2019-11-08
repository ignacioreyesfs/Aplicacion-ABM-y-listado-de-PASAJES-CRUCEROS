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
    public partial class SeleccionarCompraOReserva : Form
    {
        CrearPasaje pasaje;
        public SeleccionarCompraOReserva(CrearPasaje pasaje)
        {
            InitializeComponent();
            this.pasaje = pasaje;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            Comprar compra = new Comprar(pasaje);
            compra.Show();
            this.Close();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            Int32 idReserva = new CrearReserva().Crear();
            while (pasaje.pasajeros > 0)
            {
                new CrearPasaje(idReserva, pasaje.cliente_id, null, pasaje.viaje_codigo, pasaje.cabina_id).Crear();
                pasaje.pasajeros--;
            }

            MessageBox.Show("La reserva del pasaje resulto exitosa. \nEl codigo de la reserva es " + idReserva + ". \nTiene hasta 3 dias desde la fecha actual para realizar el pago", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }
    }
}
