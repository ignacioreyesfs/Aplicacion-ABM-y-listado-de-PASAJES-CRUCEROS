using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class  Pasaje
    {
        public Int32 id { get; set; }
        public Reserva reserva { get; set; }
        public Cliente cliente { get; set; }
        public Compra compra { get; set; }
        public Viaje viaje { get; set; }
        public Cabina cabina { get; set; }
        public Double? precio { get; set; }
        public Int32? codigo { get; set; }

        public Pasaje(Int32 id, Reserva reserva, Cliente cliente, Compra compra, Viaje viaje, Cabina cabina,
            Double? precio, Int32? codigo)
        {
            this.id = id;
            this.reserva = reserva;
            this.cliente = cliente;
            this.compra = compra;
            this.viaje = viaje;
            this.cabina = cabina;
            this.precio = precio;
            this.codigo = codigo;
        }
    }
}
