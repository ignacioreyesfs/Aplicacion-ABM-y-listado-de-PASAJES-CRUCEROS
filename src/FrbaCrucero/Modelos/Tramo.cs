using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Tramo
    {
        public Int32 id { get; set; }
        public String puertoDesde { get; set; }
        public String puertoHasta { get; set; }
        public Double precio_base { get; set; }

        public Tramo(Int32 id, String puertoDesde, String puertoHasta, Double precio_base)
        {
            this.id = id;
            this.puertoDesde = puertoDesde;
            this.puertoHasta = puertoHasta;
            this.precio_base = precio_base;
        }
    }
}
