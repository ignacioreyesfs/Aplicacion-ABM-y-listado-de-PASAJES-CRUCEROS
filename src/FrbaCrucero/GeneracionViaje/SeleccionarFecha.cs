using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class SeleccionarFecha : Form
    {
        FormGenerarViaje form;
        TextBox textBoxParam;

        public SeleccionarFecha(FormGenerarViaje form, TextBox textBoxParam)
        {
            InitializeComponent();
            this.form = form;
            this.textBoxParam = textBoxParam;
        }

        private void buttonSeleccionarFecha_Click(object sender, EventArgs e)
        {
            form.textBoxParam.Text = dateTimePickerFecha.Value.ToString();
            this.Close();
        }
    }
}
