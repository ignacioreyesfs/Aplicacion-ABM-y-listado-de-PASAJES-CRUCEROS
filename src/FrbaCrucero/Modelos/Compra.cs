using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class Compra
    {
        Int32 codigo { get; set; }
        Int32 codigoPasaje { get; set; }
        MetodoPago metodoPago { get; set; }
        DateTime fecha { get; set; }

        public Compra(Int32 codigo, Int32 codigoPasaje, MetodoPago metodoPago, DateTime fecha) 
        {
            this.codigo = codigo;
            this.codigoPasaje = codigoPasaje;
            this.metodoPago = metodoPago;
            this.fecha = fecha;
        }
    }
}
