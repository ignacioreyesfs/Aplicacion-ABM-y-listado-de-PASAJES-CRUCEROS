using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.ListadoEstadistico
{
    public class CrucerosSinServicio
    {
        public ListadoEstadisticoForm CrucerosConMasDiasSinServicio { get; set; }
        private RepoTop5 repo;

        public CrucerosSinServicio(ListadoEstadisticoForm form)
        {
            CrucerosConMasDiasSinServicio = form;
            repo = new RepoTop5("listado_estadistico");
        }

        internal void GetCrucerosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
            ShowListado cruceros = repo.getCrucerosConMasDiasFueraDeServicio(anioSeleccionado, semestreSeleccionado);

            if (cruceros.Listado != null)
            {
                CrucerosConMasDiasSinServicio.showRecorridos(cruceros);
            }
            else
            {
                CrucerosConMasDiasSinServicio.showErrorMessage("No se pudieron encontrar cruceros que coincidan con su busqueda.");
            }

        }

    }
}

