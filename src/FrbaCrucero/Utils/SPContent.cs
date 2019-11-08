using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Utils
{
    public class SPContent
    {
        public SqlDbType Tipo { get; set; }
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public SPContent(SqlDbType tipo, string nombre, object valor)
        {
            Tipo = tipo;
            Nombre = nombre;
            Valor = valor;
        }


    }
}
