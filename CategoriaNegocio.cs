using AccesoDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
		public List<Categoria> listar()
		{
			List<Categoria> lista = new List<Categoria>();
			ConexionDatos datos = new ConexionDatos();

			try
			{
				datos.setearQuery("select Id, Descripcion from CATEGORIAS");
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					Categoria aux = new Categoria();
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
