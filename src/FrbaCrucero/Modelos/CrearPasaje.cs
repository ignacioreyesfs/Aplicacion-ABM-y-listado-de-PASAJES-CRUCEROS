using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    public class CrearPasaje
    {
        public Int32? reserva_codigo { get; set; }
        public Int32 cliente_id { get; set; }
        public Int32? compra_codigo { get; set; }
        public Int32 viaje_codigo { get; set; }
        public Int32 cabina_id { get; set; }
        public Double precio { get; set; }
        public Int32 pasajeros { get; set; }

        public CrearPasaje() { }

        public CrearPasaje(Int32? reserva_codigo, Int32 cliente_id, Int32? compra_codigo, Int32 viaje_codigo, Int32 cabina_id)
        {
            this.reserva_codigo = reserva_codigo;
            this.cliente_id = cliente_id;
            this.compra_codigo = compra_codigo;
            this.viaje_codigo = viaje_codigo;
            this.cabina_id = cabina_id;
            this.precio = this.calcularPrecioPasaje();
        }

        public void Crear()
        {
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Insertar_pasaje");
                cmdInsertar.CommandType = CommandType.StoredProcedure;
                cmdInsertar.Parameters.Add(new SqlParameter("@reserva_codigo", reserva_codigo));
                cmdInsertar.Parameters.Add(new SqlParameter("@cliente_id", cliente_id));
                cmdInsertar.Parameters.Add(new SqlParameter("@compra_codigo", compra_codigo));
                cmdInsertar.Parameters.Add(new SqlParameter("@viaje_codigo", viaje_codigo));
                cmdInsertar.Parameters.Add(new SqlParameter("@cabina_codigo", cabina_id));
                cmdInsertar.Parameters.Add(new SqlParameter("@precio", precio));
                ConexionDB.instancia.ejecutarQuery(cmdInsertar);
        }

        private Double calcularPrecioPasaje()
        {
            String parametroOutput = "precio_final";
            SqlCommand cmdInsertar = new SqlCommand("FGNN_19.Calcular_costo_pasaje");
            cmdInsertar.CommandType = CommandType.StoredProcedure;
            cmdInsertar.Parameters.Add(new SqlParameter("idViaje", viaje_codigo));
            cmdInsertar.Parameters.Add(new SqlParameter("idCabina", cabina_id));
            cmdInsertar.Parameters.Add(parametroOutput, SqlDbType.Decimal).Direction = ParameterDirection.Output;
            return ConexionDB.instancia.ejecutarStoredProcedureConOutput(cmdInsertar, parametroOutput);
        }


    }
}
