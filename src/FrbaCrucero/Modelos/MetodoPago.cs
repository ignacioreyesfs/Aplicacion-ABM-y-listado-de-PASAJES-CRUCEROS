using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class MetodoPago
    {
        Int32 id { get; set; }
        String descripcion { get; set; }
        Int16 cuotas { get; set; }

        public MetodoPago(Int32 id, String descripcion, Int16 cuotas)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.cuotas = cuotas;
        }
    }
}
