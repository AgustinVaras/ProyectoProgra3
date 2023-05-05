using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexiones
{
    public class MarcaDatos
    {
        public List<Marca> Listar()
        {
            List<Marca> Listar = new List<Marca>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select Id, Descripcion as Marca From MARCAS");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Marca"];
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
