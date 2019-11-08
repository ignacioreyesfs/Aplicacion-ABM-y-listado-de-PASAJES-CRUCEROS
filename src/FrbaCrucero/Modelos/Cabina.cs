using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class Cabina
    {
        public Int32 codigo { get; set; }
        public Int32 crucero_id { get; set; }
        public Int32 numero { get; set; }
        public Int32 piso { get; set; }
        public TipoCabina tipoCabina { get; set; }
        public Int16 estado { get; set; }

        public Cabina(Int32 codigo, Int32 crucero_id, Int32 numero, Int32 piso, TipoCabina tipoCabina, Int16 estado)
        {
            this.codigo = codigo;
            this.crucero_id = crucero_id;
            this.numero = numero;
            this.piso = piso;
            this.tipoCabina = tipoCabina;
            this.estado = estado;
        }

    }
}
