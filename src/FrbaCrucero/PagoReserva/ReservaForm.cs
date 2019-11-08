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

namespace FrbaCrucero.PagoReserva
{
    public partial class ReservaForm : Form
    {
        private List<Pasaje> pasajes;
        private Double totalAPagar;

        public ReservaForm(List<Pasaje> pasajes)
        {
            InitializeComponent();
            this.pasajes = pasajes;
            this.totalAPagar = pasajes.Sum(pasaje => getValorOrCero(pasaje.precio));

            labelCantPasajInfo.Text = pasajes.Count().ToString();
            
            string nombreCliente = pasajes.First().cliente.nombre;
            string apellidoCliente = pasajes.First().cliente.apellido;
            labelClienteInfo.Text = nombreCliente + " " + apellidoCliente;

            labelCodigoInfo.Text = pasajes.First().reserva.codigo.ToString();
            labelMontoInfo.Text = totalAPagar.ToString(); 
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Double getValorOrCero(Double? precio)
        {
            if (!precio.HasValue)
            {
                return 0;
            }
            else
            {
                return precio.Value;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            SeleccionarMetodoPagoReservaForm seleccionarMetodoPago = new SeleccionarMetodoPagoReservaForm(pasajes, totalAPagar);
            seleccionarMetodoPago.Show();
            this.Close();
        }

    }
}
