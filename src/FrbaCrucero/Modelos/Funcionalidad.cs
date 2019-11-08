using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class Funcionalidad
    {
        public Int32 id { get; set; }
        public String descripcion { get; set; }
        
        public Funcionalidad(Int32 id, String descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

    }
}
