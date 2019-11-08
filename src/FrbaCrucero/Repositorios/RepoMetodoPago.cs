using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoMetodoPago : AbstractRepo<MetodoPago>
    {
        public static RepoMetodoPago instancia = new RepoMetodoPago("[FGNN_19].[Metodos_Pago]");

        public RepoMetodoPago(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<MetodoPago> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<MetodoPago> metodoPagos = new List<MetodoPago>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = Convert.ToString(row["descripcion"]);
                Int16 cuotas = Convert.ToInt16(row["cuotas"]);
                
                MetodoPago metodoPago = new MetodoPago(id, descripcion, cuotas);

                metodoPagos.Add(metodoPago);
            }

            return metodoPagos;
        }

        public override int Crear(MetodoPago entidad)
        {
            throw new NotImplementedException();
        }
    }
}
