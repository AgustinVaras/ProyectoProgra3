﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexiones
{
    public class ImagenesDatos
    {
        public List<Imagen> Listar()
        {
            List<Imagen> Listar = new List<Imagen>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select Id, IdArticulo, ImagenUrl as Imagen From IMAGENES");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.IdArticulo = (int)Datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)Datos.Lector["Imagen"];
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

        public void Agregar(Imagen nuevo)
        {
            AccesoSQL datos = new AccesoSQL();

            try
            {
                datos.Consulta("Insert into IMAGENES(IdArticulo, ImagenUrl) VALUES('" + nuevo.IdArticulo + "', '" + nuevo.ImagenUrl + "')");
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

        public List<Imagen> Buscar(string TipoBusqueda, string Valor)
        {
            List<Imagen> busqueda = new List<Imagen>();
            AccesoSQL Datos = new AccesoSQL();
            try
            {
                Datos.Consulta("Select Id, IdArticulo, ImagenUrl From Imagenes Where " + TipoBusqueda + " LIKE '" + Valor + "'");
                Datos.EjecutarLectura();
                while (Datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.IdArticulo = (int)Datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)Datos.Lector["ImagenUrl"];

                    busqueda.Add(aux);
                }
                return busqueda;
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
