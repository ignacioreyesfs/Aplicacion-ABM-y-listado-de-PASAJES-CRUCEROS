using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class Viaje
    {
        public Int32 id { get; set; }
        public Int32 crucero_id { get; set; }
        public Int32 recorrido_codigo { get; set; }
        public String crucero_nombre { get; set; }
        public String puertoDesde { get; set; }
        public String puertoHasta { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime? fecha_fin_estimada { get; set; }

        public Viaje(Int32 id, Int32 crucero_id, Int32 recorrido_codigo, DateTime fecha_inicio, DateTime fecha_fin, DateTime? fecha_fin_estimada)
        {
            this.id = id;
            this.crucero_id = crucero_id;
            this.recorrido_codigo = recorrido_codigo;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.fecha_fin_estimada = fecha_fin_estimada;
            
        }
    }
}
