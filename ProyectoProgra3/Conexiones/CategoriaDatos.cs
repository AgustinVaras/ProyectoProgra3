using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexiones
{
    public class CategoriaDatos
    {
        public List<Categoria> Listar()
        {
            List<Categoria> Listar = new List<Categoria>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select Id, Descripcion as Categ From CATEGORIAS");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Categ"];
                    Listar.Add(aux);
                }
                return Listar;
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
    }
}
