using System;
using System.Linq;
using Lewis_e1_ap2.DAL;
using Lewis_e1_ap2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lewis_e1_ap2.BLL
{
    public class ArticulosBLL
    {
          public static bool Guardar(Articulos articulo)
        {
            if (!Existe(articulo.ArticuloId))
            {
                return Insertar(articulo);
            }
            else
            {
                return Modificar(articulo);
            }
        }

        public static bool Existe(int id)
        {
            var encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Articulos.Any(p => p.ArticuloId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

          public static bool Insertar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            
            try
            {
                contexto.Articulos.Add(articulo);
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

           public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var articulo = contexto.Articulos.Find(id);

                if(articulo != null)
                {
                    contexto.Remove(articulo);
                    paso =( contexto.SaveChanges() > 0);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Articulos Buscar(int id)
        {
            Articulos articulos = new Articulos();
            Contexto contexto = new Contexto();

            try
            {
                articulos = contexto.Articulos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return articulos;
        }

    }
}