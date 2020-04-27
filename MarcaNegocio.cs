using AccesoDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
		public List<Marca> listar()
		{
			List<Marca> lista = new List<Marca>();
			ConexionDatos datos = new ConexionDatos();

			try
			{
				datos.setearQuery("select Id, Descripcion from MARCAS");
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					Marca aux = new Marca();
					aux.id = datos.lector.GetInt32(0);
					aux.descripcion = datos.lector.GetString(1);

					lista.Add(aux);
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
	}
}
