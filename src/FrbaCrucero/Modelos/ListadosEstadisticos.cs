using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class ListadosEstadisticos
    {
        public string PrimeraColumna { get; set; }
        public string SegundaColumna { get; set; }
        public int TerceraColumna { get; set; }
    }

    public class ShowListado
    {
        public List<ListadosEstadisticos> Listado { get; set; }
        public int Descripcion { get; set; }
    }
}
