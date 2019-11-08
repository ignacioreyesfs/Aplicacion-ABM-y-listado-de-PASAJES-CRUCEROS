using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.ListadoEstadistico
{
    public class RecorridosConMasCabinas
    {
        public ListadoEstadisticoForm RecorridosConMasCabinasLibres { get; set; }
        private RepoTop5 repo;

        public RecorridosConMasCabinas(ListadoEstadisticoForm form)
        {
            RecorridosConMasCabinasLibres = form;
            repo = new RepoTop5("listado_estadistico");
        }

        internal void GetRecorridosConFiltros(string anioSeleccionado, string semestreSeleccionado)
        {
            semestreSeleccionado = semestreSeleccionado.Equals("Primer semestre") ? "1" : "2";
            ShowListado recorridos = repo.getRecorridosConMasCabinasLibres(anioSeleccionado, semestreSeleccionado);

            if (recorridos.Listado != null)
            {
                RecorridosConMasCabinasLibres.showRecorridos(recorridos);
            }
            else
            {
                RecorridosConMasCabinasLibres.showErrorMessage("No se pudieron encontrar recorridos que coincidan con su busqueda.");
            }

        }

    }

}

