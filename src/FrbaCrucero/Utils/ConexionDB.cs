using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FrbaCrucero
{
	public class ConexionDB
	{
		public static ConexionDB instancia = new ConexionDB();
		private SqlConnection cnn;

        public SqlConnection crearConexion() 
		{
            var connectionString = ConfigurationManager.ConnectionStrings["GD1C2019DB"].ConnectionString;
            cnn = new SqlConnection(connectionString);
            return cnn;
        }
		
		public void abrirConexion() 
		{
            cnn.Open();
        }
		
		public void cerrarConexion() 
		{
            cnn.Close();
        }
		
        public DataTable obtenerData(String query) {
			try
			{
            	SqlConnection cnn = crearConexion();
                cnn.Open();

				DataTable tabla = new DataTable();
            	SqlCommand sqlCmd = new SqlCommand(query, cnn);

            	tabla.Load(sqlCmd.ExecuteReader());
                cnn.Close();
				
				return tabla;
			}
			catch (Exception)
			{
                throw;
            } 
        }

        public DataTable obtenerData(SqlCommand cmd)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();
                cmd.Connection = cnn;
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();

                return tabla;
            } catch (Exception ex)
            {
                throw ex;
            }
        }
           
        public void ejecutarQuery(SqlCommand cmd)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();

                cmd.Connection = cnn;
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        public SqlCommand getStoreProcedure(string storeProcedureName)
        {
            SqlCommand sp = new SqlCommand(storeProcedureName, this.cnn);
            sp.CommandType = CommandType.StoredProcedure;
            return sp;
        }
    
       public Int32 ejecutarQueryInsert(SqlCommand cmd)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();

                 cmd.Connection = cnn;
                Int32 id = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();

                 return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 ejecutarStoredProcedureConOutput(SqlCommand cmd, String parametroOutput)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();
              
                cmd.Connection = cnn;
              
                int result = cmd.ExecuteNonQuery();
                Int32 resultado = Convert.ToInt32(cmd.Parameters[parametroOutput].Value);
                cnn.Close();
                return resultado;
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> ejecutarStoredProcedureConOutputs(SqlCommand cmd, List<String> parametrosOutput)
        {
            try
            {
                SqlConnection cnn = crearConexion();
                cnn.Open();

                cmd.Connection = cnn;

                int result = cmd.ExecuteNonQuery();
                List<object> listaResultados = new List<object>();
                foreach (String parametro in parametrosOutput)
                {
                    listaResultados.Add(cmd.Parameters[parametro].Value);
                }
                cnn.Close();
                return listaResultados;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}