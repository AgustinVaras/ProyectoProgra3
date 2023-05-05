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
            ///SQL 
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();

            ///Instancia DataReader
            //SqlDataReader lector;

            List<Articulo> lista = new List<Articulo>();
            AccesoSQL Datos = new AccesoSQL();



            try
            {

                ///Conexion a la DB SQL
                //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                //comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "Select Codigo, Nombre, Descripcion, Precio from ARTICULOS";
                //comando.Connection = conexion;

                //conexion.Open();
                //lector = comando.ExecuteReader();
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
                //conexion.Close();
                Datos.CerrarConexion();
            }
            
        
        
        
        }










    }

}
