using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class Reserva
    {
        public Int32 codigo { get; set; }
        public Int16 habilitado { get; set; }
        public DateTime fecha { get; set; }

        public Reserva(Int32 codigo, Int16 habilitado, DateTime fecha )
        {
            this.codigo = codigo;
            this.habilitado = habilitado;
            this.fecha = fecha;
        }

    }
}
