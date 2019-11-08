using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraPasaje
{
    public partial class SeleccionarFecha : Form
    {
        TextBox textBoxParam;

        public SeleccionarFecha(TextBox textBoxParam)
        {
            InitializeComponent();
            this.textBoxParam = textBoxParam;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            textBoxParam.Text = dateTimePickerFecha.Value.ToString();
            this.Close();
        }

    }
}
