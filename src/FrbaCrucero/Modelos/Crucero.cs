using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Crucero
    {

        public Int32 id { get; set; }
        public String nombre { get; set; }
        public DateTime? fecha_alta { get; set; }
        public String modelo { get; set; }
        public Int32 fabricante_id { get; set; }
        public String tipo_servicio { get; set; }
        public Int16 baja_servicio { get; set; }
        public Int16 baja_vida_util { get; set; }
        public DateTime? fecha_fuera_servicio { get; set; }
        public DateTime? fecha_reinicio_servicio { get; set; }
        public DateTime? fecha_baja_definitiva { get; set; }
        public Int16? cant_cabinas { get; set; }
        public Int16 habilitado { get; set; }

        public Crucero(Int32 id, String nombre, DateTime? fecha_alta, String modelo, 
                       Int32 fabricante_id, String tipo_servicio, Int16 baja_servicio, 
                       Int16 baja_vida_util, DateTime? fecha_fuera_servicio, 
                       DateTime? fecha_reinicio_servicio, DateTime? fecha_baja_definitiva,
                       Int16? cant_cabinas, Int16 habilitado)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_alta = fecha_alta;
            this.modelo = modelo;
            this.fabricante_id = fabricante_id;
            this.tipo_servicio = tipo_servicio;
            this.baja_servicio = baja_servicio;
            this.baja_vida_util = baja_vida_util;
            this.fecha_fuera_servicio = fecha_fuera_servicio;
            this.fecha_reinicio_servicio = fecha_reinicio_servicio;
            this.fecha_baja_definitiva = fecha_baja_definitiva;
            this.cant_cabinas = cant_cabinas;
            this.habilitado = habilitado;
        }
    }
}
