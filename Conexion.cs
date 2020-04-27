using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AccesoDatos
{
    public class ConexionDatos
    {
        public SqlDataReader lector { get; set; }
        public SqlConnection conexion { get; set; }
        public SqlCommand comando { get; set; }

        public ConexionDatos()
        {
            conexion = new SqlConnection("data source=DESKTOP-VP40NHH\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }
        public void setearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void setearSP(string sp)
        {
            //----------------
        }

        public void agregarParametro(string nombre,object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);


        }
        public void ejecutarLector()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //conexion.Close();
            }
        }
        public void cerrarConexion()
        {

            conexion.Close();
        }
        public void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
 
}

