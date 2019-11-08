using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class Rol
    {
        public Int32 id { get; set; }
        public String descripcion { get; set; }
        public Int16 habilitado { get; set; }
        public List<Funcionalidad> funcionalidades { get; set; }

        public Rol(Int32 id, String descripcion, Int16 habilitado)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.habilitado = habilitado;
            this.funcionalidades = new List<Funcionalidad>();
        }

        public Rol() 
        {
            this.funcionalidades = new List<Funcionalidad>();
        }

        public List<Funcionalidad> GetFuncionalidades()
        {
            return funcionalidades;
        }

        public void AgregarFuncionalidad(Funcionalidad funcionalidad)
        {
            funcionalidades.Add(funcionalidad);
        }

        public void EliminarFuncionalidad(Funcionalidad funcioanlidad)
        {
            funcionalidades.Remove(funcioanlidad);
        }

    }
}
