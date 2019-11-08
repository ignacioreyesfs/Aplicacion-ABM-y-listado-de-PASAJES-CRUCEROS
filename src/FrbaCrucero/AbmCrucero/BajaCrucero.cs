using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class BajaCrucero : Form
    {
        public ListadoCrucerosForm listadoCruceros;
        public Int32 id;
        public BajaCrucero(ListadoCrucerosForm listadoCruceros, Int32 id)
        {
            InitializeComponent();
            this.listadoCruceros = listadoCruceros;
            this.id = id;
        }

        private void buttonBajaTemporal_Click(object sender, EventArgs e)
        {
            BajaTemporal bajaTemporal = new BajaTemporal(this, id);
            bajaTemporal.Show();
        }

        private void buttonBajaDefinitiva_Click(object sender, EventArgs e)
        {
            BajaDefinitiva bajaDefinitiva = new BajaDefinitiva(this, id);
            bajaDefinitiva.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
