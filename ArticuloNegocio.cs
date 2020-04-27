using AccesoDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			Articulo aux;
			ConexionDatos datos = new ConexionDatos();

			try
			{
				datos.setearQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion, MARCAS.Id as 'IdMarca', " +
								  "MARCAS.Descripcion as 'DescripcionMarca', CATEGORIAS.Id as 'IdCategoria', CATEGORIAS.Descripcion as " +
								  "'DescripcionCategoria', ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS inner join MARCAS on ( " +
								  "ARTICULOS.IdMarca = MARCAS.Id ) inner join CATEGORIAS on ( ARTICULOS.IdCategoria = CATEGORIAS.Id )");
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					aux = new Articulo();
					aux.id = (int)datos.lector.GetInt32(0);
					aux.cod = (string)datos.lector.GetString(1);
					aux.nombre = (string)datos.lector.GetString(2);
					aux.descripcion = (string)datos.lector.GetString(3);
					aux.marca.id = (int)datos.lector.GetInt32(4);
					aux.marca.descripcion = (string)datos.lector.GetString(5);
					aux.categoria.id = (int)datos.lector.GetInt32(6);
					aux.categoria.descripcion = (string)datos.lector.GetString(7);
					aux.imagenUrl = (string)datos.lector.GetString(8);
					aux.precio = (double)datos.lector.GetDecimal(9);

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
		public void agregar(Articulo nuevo)
		{
			SqlCommand comando = new SqlCommand();
			SqlConnection conexion = new SqlConnection();

			try
			{
				conexion.ConnectionString = "data source = DESKTOP-VP40NHH\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.Connection = conexion;
				comando.CommandText = "insert into ARTICULOS values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagen, @precio); ";
				//comando.Parameters.Clear();
				comando.Parameters.AddWithValue("@codigo", nuevo.cod);
				comando.Parameters.AddWithValue("@nombre", nuevo.nombre);
				comando.Parameters.AddWithValue("@descripcion", nuevo.descripcion);
				comando.Parameters.AddWithValue("@idmarca", nuevo.marca.id.ToString());
				comando.Parameters.AddWithValue("@idCategoria", nuevo.categoria.id.ToString());
				comando.Parameters.AddWithValue("@imagen", nuevo.imagenUrl);
				comando.Parameters.AddWithValue("@precio", nuevo.precio);

				comando.Connection = conexion;
				conexion.Open();
				comando.ExecuteNonQuery();


				/*datos.setearQuery("insert into ARTICULOS values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagen, @precio);");
				datos.comando.Parameters.AddWithValue("@codigo", nuevo.cod);
				datos.comando.Parameters.AddWithValue("@nombre", nuevo.nombre);
				datos.comando.Parameters.AddWithValue("@descripcion", nuevo.descripcion);
				datos.comando.Parameters.AddWithValue("@idmarca", nuevo.marca.id.ToString());
				datos.comando.Parameters.AddWithValue("@idCategoria", nuevo.categoria.id.ToString());
				datos.comando.Parameters.AddWithValue("@imagen", nuevo.imagenUrl);
				datos.comando.Parameters.AddWithValue("@precio", nuevo.precio);
				datos.ejecutarLector();*/

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

		public void modificar(Articulo nuevo)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();

			try
			{
				conexion.ConnectionString = "data source = DESKTOP-VP40NHH\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "update ARTICULOS set ARTICULOS.Nombre = @nombre, " +
					"ARTICULOS.Descripcion = @descripcion, ARTICULOS.IdMarca = @idMarca, ARTICULOS.IdCategoria = @idCategoria, " +
					"ARTICULOS.ImagenUrl = @imagenUrl, ARTICULOS.Precio = @precio where ARTICULOS.Codigo = @codigo";
				// comando.Parameters.Clear();
				comando.Parameters.AddWithValue("@nombre", nuevo.nombre);
				comando.Parameters.AddWithValue("@descripcion", nuevo.descripcion);
				comando.Parameters.AddWithValue("@idMarca", nuevo.marca.id);
				comando.Parameters.AddWithValue("@idCategoria", nuevo.categoria.id);
				comando.Parameters.AddWithValue("@imagenUrl", nuevo.imagenUrl);
				comando.Parameters.AddWithValue("@precio", nuevo.precio);
				comando.Parameters.AddWithValue("@codigo", nuevo.cod);
				comando.Connection = conexion;

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
		public void BajaArticulo(Articulo artBaja)
		{
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();

			try
			{
				conexion.ConnectionString = "data source = DESKTOP-VP40NHH\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "delete from ARTICULOS where Codigo = @codigo";
				// comando.Parameters.Clear();
				comando.Parameters.AddWithValue("@codigo", artBaja.cod);

				comando.Connection = conexion;

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
		public List<Articulo> BuscarArticuloXcodigo(string artBusq)
		{
			List<Articulo> lista = new List<Articulo>();
			Articulo aux;
			ConexionDatos datos = new ConexionDatos();

			try
			{

				datos.setearQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion,MARCAS.Id as 'IdMarca'," +
					" MARCAS.Descripcion as 'DescripciondeMarca', CATEGORIAS.Id as 'IDCategoria',CATEGORIAS.Descripcion as 'DescripciondeCategoria'," +
					" ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS inner join MARCAS on (ARTICULOS.IdMarca = MARCAS.Id) " +
					"inner join CATEGORIAS on (ARTICULOS.IdCategoria= CATEGORIAS.Id) where ARTICULOS.Codigo like @BusquedaCod");
				datos.agregarParametro("@BusquedaCod", artBusq);
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					aux = new Articulo();
					aux.id = datos.lector.GetInt32(0);
					aux.cod = datos.lector.GetString(1);
					aux.nombre = datos.lector.GetString(2);
					aux.descripcion = datos.lector.GetString(3);
					aux.marca.id = datos.lector.GetInt32(4);
					aux.marca.descripcion = datos.lector.GetString(5);
					aux.categoria.id = datos.lector.GetInt32(6);
					aux.categoria.descripcion = datos.lector.GetString(7);
					aux.imagenUrl = datos.lector.GetString(8);
					aux.precio = (double)datos.lector.GetDecimal(9);

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
		public List<Articulo> BuscarArticuloXmarca(string artBusqM)
		{
			List<Articulo> lista = new List<Articulo>();
			Articulo aux;
			ConexionDatos datos = new ConexionDatos();

			try
			{

				datos.setearQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion,MARCAS.Id as 'IdMarca'," +
					" MARCAS.Descripcion as 'DescripciondeMarca', CATEGORIAS.Id as 'IDCategoria',CATEGORIAS.Descripcion as 'DescripciondeCategoria'," +
					" ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS inner join MARCAS on (ARTICULOS.IdMarca = MARCAS.Id) " +
					"inner join CATEGORIAS on (ARTICULOS.IdCategoria= CATEGORIAS.Id) where MARCAS.Descripcion like '%'+ @BusquedaMar +'%'");
				datos.agregarParametro("@BusquedaMar", artBusqM);
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					aux = new Articulo();
					aux.id = datos.lector.GetInt32(0);
					aux.cod = datos.lector.GetString(1);
					aux.nombre = datos.lector.GetString(2);
					aux.descripcion = datos.lector.GetString(3);
					aux.marca.id = datos.lector.GetInt32(4);
					aux.marca.descripcion = datos.lector.GetString(5);
					aux.categoria.id = datos.lector.GetInt32(6);
					aux.categoria.descripcion = datos.lector.GetString(7);
					aux.imagenUrl = datos.lector.GetString(8);
					aux.precio = (double)datos.lector.GetDecimal(9);

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
		public List<Articulo> BuscarArticuloXcategoria(string artBusqC)
		{
			List<Articulo> lista = new List<Articulo>();
			Articulo aux;
			ConexionDatos datos = new ConexionDatos();

			try
			{

				datos.setearQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion,MARCAS.Id as 'IdMarca'," +
					" MARCAS.Descripcion as 'DescripciondeMarca', CATEGORIAS.Id as 'IDCategoria',CATEGORIAS.Descripcion as 'DescripciondeCategoria'," +
					" ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS inner join MARCAS on (ARTICULOS.IdMarca = MARCAS.Id) " +
					"inner join CATEGORIAS on (ARTICULOS.IdCategoria= CATEGORIAS.Id) where CATEGORIAS.Descripcion like '%'+ @BusquedaCat +'%'");
				datos.agregarParametro("@BusquedaCat", artBusqC);
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					aux = new Articulo();
					aux.id = datos.lector.GetInt32(0);
					aux.cod = datos.lector.GetString(1);
					aux.nombre = datos.lector.GetString(2);
					aux.descripcion = datos.lector.GetString(3);
					aux.marca.id = datos.lector.GetInt32(4);
					aux.marca.descripcion = datos.lector.GetString(5);
					aux.categoria.id = datos.lector.GetInt32(6);
					aux.categoria.descripcion = datos.lector.GetString(7);
					aux.imagenUrl = datos.lector.GetString(8);
					aux.precio = (double)datos.lector.GetDecimal(9);

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

		public List<Articulo> DetalleArticulo(string artDetalleID)
		{
			List<Articulo> lista = new List<Articulo>();
			Articulo aux;
			ConexionDatos datos = new ConexionDatos();

			try
			{

				datos.setearQuery("select ARTICULOS.Id, ARTICULOS.Codigo, ARTICULOS.Nombre, ARTICULOS.Descripcion, " +
					"MARCAS.Id as 'IdMarca', MARCAS.Descripcion as 'DescripcionMarca', CATEGORIAS.Id as 'IdCategoria'," +
					" CATEGORIAS.Descripcion as 'DescripcionCategoria', ARTICULOS.ImagenUrl, ARTICULOS.Precio from ARTICULOS " +
					"inner join MARCAS on ( ARTICULOS.IdMarca = MARCAS.Id ) inner join CATEGORIAS on ( ARTICULOS.IdCategoria " +
					"= CATEGORIAS.Id ) where ARTICULOS.Id like @termino");
				datos.agregarParametro("@termino", artDetalleID);
				datos.ejecutarLector();
				while (datos.lector.Read())
				{
					aux = new Articulo();
					aux.id = datos.lector.GetInt32(0);
					aux.cod = datos.lector.GetString(1);
					aux.nombre = datos.lector.GetString(2);
					aux.descripcion = datos.lector.GetString(3);
					aux.marca.id = datos.lector.GetInt32(4);
					aux.marca.descripcion = datos.lector.GetString(5);
					aux.categoria.id = datos.lector.GetInt32(6);
					aux.categoria.descripcion = datos.lector.GetString(7);
					aux.imagenUrl = datos.lector.GetString(8);
					aux.precio = (double)datos.lector.GetDecimal(9);

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
