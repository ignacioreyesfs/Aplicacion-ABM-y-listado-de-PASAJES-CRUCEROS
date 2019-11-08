using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCrucero.Modelos;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using FrbaCrucero.Utils;
using System.Configuration;

namespace FrbaCrucero.Repositorios
{
    class RepoTop5 : AbstractRepo<ListadosEstadisticos>
    {
        public RepoTop5(string nombreTabla) : base(nombreTabla) { 
        }

        public override List<ListadosEstadisticos> ObtenerModelosDesdeTabla(System.Data.DataTable tabla)
        {
            throw new NotImplementedException();
        }

        public override int Crear(ListadosEstadisticos entidad)
        {
            throw new NotImplementedException();
        }

        private List<ListadosEstadisticos> getListado(string anioSeleccionado, string semestreSeleccionado, string nameStore)
        {
            List<ListadosEstadisticos> listado = new List<ListadosEstadisticos>();

            try
            {
                SPContent parametro1 = new SPContent(SqlDbType.Int, "semestre", int.Parse(semestreSeleccionado));
                SPContent parametro2 = new SPContent(SqlDbType.Int, "anio", int.Parse(anioSeleccionado));
                List<SPContent> parametros = new List<SPContent>();
                parametros.Add(parametro1);
                parametros.Add(parametro2);
                this.conexionDB.crearConexion();
                this.conexionDB.abrirConexion();

                SqlCommand procedure = CreateProcedure(nameStore, parametros);
                SqlDataReader sqlReader = procedure.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        ListadosEstadisticos fila = new ListadosEstadisticos();
                        fila.PrimeraColumna = sqlReader.GetString(0);
                        fila.SegundaColumna = sqlReader.GetString(1);
                        fila.TerceraColumna = sqlReader.GetInt32(2);

                        listado.Add(fila);
                    }
                }

            }
            catch (Exception)
            {
                listado = null;
            }
            finally
            {
                this.conexionDB.cerrarConexion();
            }
            return listado;
        }


        private List<ListadosEstadisticos> getListadoConFecha(string anioSeleccionado, string semestreSeleccionado, string nameStore)
        {
            List<ListadosEstadisticos> listado = new List<ListadosEstadisticos>();

            try
            {
                SPContent parametro1 = new SPContent(SqlDbType.Int, "semestre", int.Parse(semestreSeleccionado));
                SPContent parametro2 = new SPContent(SqlDbType.Int, "anio", int.Parse(anioSeleccionado));
                SPContent parametro3 = new SPContent(SqlDbType.DateTime2, "fechaHoy", Convert.ToDateTime(ConfigurationManager.AppSettings["Date"]));
                List<SPContent> parametros = new List<SPContent>();
                parametros.Add(parametro1);
                parametros.Add(parametro2);
                parametros.Add(parametro3);
                this.conexionDB.crearConexion();
                this.conexionDB.abrirConexion();

                SqlCommand procedure = CreateProcedure(nameStore, parametros);
                SqlDataReader sqlReader = procedure.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        ListadosEstadisticos fila = new ListadosEstadisticos();
                        fila.PrimeraColumna = sqlReader.GetString(0);
                        fila.SegundaColumna = sqlReader.GetString(1);
                        fila.TerceraColumna = sqlReader.GetInt32(2);

                        listado.Add(fila);
                    }
                }

            }
            catch (Exception)
            {
                listado = null;
            }
            finally
            {
                this.conexionDB.cerrarConexion();
            }
            return listado;
        }

        internal ShowListado getCrucerosConMasDiasFueraDeServicio(string anio, string semestre) 
        {
            ShowListado showListado = new ShowListado();
            showListado.Descripcion = 3; 
            showListado.Listado = this.getListadoConFecha(anio, semestre, "FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio");
            return showListado;
        }

        internal ShowListado getRecorridosConMasCabinasLibres(string anio, string semestre)
        {
            ShowListado showListado = new ShowListado();
            showListado.Descripcion = 2;
            showListado.Listado = this.getListado(anio, semestre, "FGNN_19.TOP5_recorridos_mas_cabinas_libres");
            return showListado;
        }

        internal ShowListado getRecorridosConPasajesMasComprados(string anio, string semestre)
        {
            ShowListado showListado = new ShowListado();
            showListado.Descripcion = 1;
            showListado.Listado = this.getListado(anio, semestre, "FGNN_19.TOP5_recorridos_mas_comprados");
            return showListado;
        }
    }
}
