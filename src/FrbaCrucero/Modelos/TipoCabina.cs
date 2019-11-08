using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class TipoCabina
    {
        Int32 id { get; set; }
        String descripcion { get; set; }
        Double porcentanjeAdicional { get; set; }

        public TipoCabina(Int32 id, String descripcion, Double porcentajeAdicional)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.porcentanjeAdicional = porcentanjeAdicional;
        }
    }
}
