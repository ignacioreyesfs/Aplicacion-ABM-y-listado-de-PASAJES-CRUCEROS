using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    interface IRepo<T> where T : class
    {
        Int32 Crear(T entidad);
        void Modificar(Int32 id, Dictionary<string, object> parametros);
        void Eliminar(Int32 id);
        List<T> EncontrarTodos();
        T EncontrarPorId(Int32 id);
    }
}
