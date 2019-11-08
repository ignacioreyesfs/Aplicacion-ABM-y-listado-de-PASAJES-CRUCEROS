using FrbaCrucero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Repositorios
{
    class RepoTipoCabina : AbstractRepo<TipoCabina>
    {
        public static RepoTipoCabina instancia = new RepoTipoCabina("[FGNN_19].[Tipos_Cabinas]");

        public RepoTipoCabina(string nombreTabla) : base(nombreTabla) 
        {
        }

        public override List<TipoCabina> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            List<TipoCabina> tipoCabinas = new List<TipoCabina>();

            foreach (DataRow row in tabla.Rows)
            {
                Int32 id = Convert.ToInt32(row["id"]);
                String descripcion = Convert.ToString(row["descripcion"]);
                Double porcentajeAdicional = Convert.ToDouble(row["porcentaje_adicional"]);

                TipoCabina tipoCabina = new TipoCabina(id, descripcion, porcentajeAdicional);

                tipoCabinas.Add(tipoCabina);
            }

            return tipoCabinas;
        }

        public override int Crear(TipoCabina entidad)
        {
            throw new NotImplementedException();
        }
    }
}
