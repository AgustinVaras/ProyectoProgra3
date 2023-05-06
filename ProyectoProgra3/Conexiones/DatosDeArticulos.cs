using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases;

namespace Conexiones
{
    public class DatosDeArticulos
    {
        public List<Articulo> listar() 
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio , C.Id Categoria, M.Id Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.IdCategoria = (int)Datos.Lector["Categoria"];
                    aux.IdMarca = (int)Datos.Lector["Marca"];
                    aux.Codigo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);

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
                Datos.CerrarConexion();
            }                               
        }

        public void Agregar(Articulo nuevo)
        {
            AccesoSQL datos = new AccesoSQL();

            try
            {
                datos.Consulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) VALUES('" + nuevo.Codigo + "', '" + nuevo.Nombre + "' , '" + nuevo.Descripcion + "' , '" + nuevo.Precio + "' , '"+ nuevo.IdCategoria +"' , '"+ nuevo.IdMarca +"')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public int Agregar_getId(Articulo nuevo)
        {
            AccesoSQL datos = new AccesoSQL();
            int id;

            try
            {
                datos.Consulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) output INSERTED.Id VALUES('" + nuevo.Codigo + "', '" + nuevo.Nombre + "' , '" + nuevo.Descripcion + "' , '" + nuevo.Precio + "' , '" + nuevo.IdCategoria + "' , '" + nuevo.IdMarca + "')");
                id = datos.EjecutarScalar();
                
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulo> Buscar(string busqueda, string criterio)
        {
            AccesoSQL Datos = new AccesoSQL();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                if (ManejoDeBusqueda(busqueda, criterio))
                {
                    criterio = ManejoDeCriterio(criterio);
                    Datos.Consulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio , C.Id Categoria, M.Id Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id where " + busqueda + " like " + criterio);
                    Datos.EjecutarLectura();
                    while (Datos.Lector.Read())
                    {
                        Articulo aux = new Articulo();
                        aux.Id = (int)Datos.Lector["Id"];
                        aux.IdCategoria = (int)Datos.Lector["Categoria"];
                        aux.IdMarca = (int)Datos.Lector["Marca"];
                        aux.Codigo = (string)Datos.Lector["Codigo"];
                        aux.Nombre = (string)Datos.Lector["Nombre"];
                        aux.Descripcion = (string)Datos.Lector["Descripcion"];
                        aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);

        public void Modificar(Articulo modificar)
        {
            AccesoSQL datos = new AccesoSQL();

            try
            {
                datos.Consulta("UPDATE into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) VALUES('" + modificar.Codigo + "', '" + modificar.Nombre + "' , '" + modificar.Descripcion + "' , '" + modificar.Precio + "' , '" + modificar.IdCategoria + "' , '" + modificar.IdMarca + "')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

                        lista.Add(aux);
                    }
                }            
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        private string ManejoDeCriterio(string criterio)
        {
            return "A." + criterio;
        }

        private bool ManejoDeBusqueda(string busqueda, string criterio)
        {
            if(criterio == "Id" || criterio == "IdMarca" || criterio == "IdCategoria")
            {
               bool isWrongType = int.TryParse(busqueda, out int id);
               return isWrongType;
            }              
            else return true;
        }
    }
}
