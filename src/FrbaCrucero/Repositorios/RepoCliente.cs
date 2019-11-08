using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoCliente : AbstractRepo<Cliente>
    {
        public static RepoCliente instancia = new RepoCliente("[FGNN_19].[Clientes]");

        public RepoCliente(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<Cliente> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String nombre = Convert.ToString(row["nombre"]);
                String apellido = Convert.ToString(row["apellido"]);
                Int32 dni = Convert.ToInt32(row["dni"]);
                String direccion = Convert.ToString(row["direccion"]);
                Int32 telefono = Convert.ToInt32(row["telefono"]);
                DateTime fechaNacimiento = Convert.ToDateTime(row["fecha_nac"]);
                String mail = Convert.ToString(row["mail"]);

                Cliente cliente = new Cliente(id, nombre, apellido, dni, direccion, telefono, fechaNacimiento, mail);

                clientes.Add(cliente);
            }

            return clientes;
        }

        public override int Crear(Cliente entidad)
        {
            throw new NotImplementedException();
        }

    }
}
