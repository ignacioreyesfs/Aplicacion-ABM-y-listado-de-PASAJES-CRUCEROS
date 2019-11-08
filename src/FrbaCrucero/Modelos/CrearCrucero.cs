using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class CrearCrucero
    {
        public String nombre { get; set; }
        public DateTime fecha_alta { get; set; }
        public String modelo { get; set; }
        public String fabricante { get; set; }
        public String tipo_servicio { get; set; }
        public Int32? cantidad_cabinas { get; set; }
        public SqlCommand cmd = new SqlCommand("FGNN_19.P_InsertarCrucero");

        public CrearCrucero(String nombre, DateTime fecha_alta, String modelo, 
                            String fabricante, String tipo_servicio, Int32? cantidad_cabinas)
        {
            this.nombre = nombre;
            this.fecha_alta = fecha_alta;
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.tipo_servicio = tipo_servicio;
            this.cantidad_cabinas = cantidad_cabinas;
        }

        public void Crear()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("fecha_alta", fecha_alta));
            cmd.Parameters.Add(new SqlParameter("modelo", modelo));
            this.AgregarFabricante(cmd, fabricante);
            cmd.Parameters.Add(new SqlParameter("tipo_servicio", tipo_servicio));
            cmd.Parameters.Add(new SqlParameter("cant_cabinas", cantidad_cabinas));

            ConexionDB.instancia.ejecutarQuery(cmd);
        }

        public void AgregarFabricante(SqlCommand command, String fabricante)
        {
            if(String.IsNullOrWhiteSpace(fabricante))
            {
                command.Parameters.Add(new SqlParameter("fabricante_id", DBNull.Value));
            }
            else
            {
                command.Parameters.Add(new SqlParameter("fabricante_id", Int32.Parse(fabricante)));
            }
        }
        
    }
}
