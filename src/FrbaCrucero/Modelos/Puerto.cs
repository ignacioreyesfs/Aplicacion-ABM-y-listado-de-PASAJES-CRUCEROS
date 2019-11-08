using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Puerto
    {
        public Int32 id { get; set; }
        public String descripcion { get; set; }

        public Puerto(Int32 id, String descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

    }
}
