using System;
using Microsoft.EntityFrameworkCore;
using Examen.Data;
using Examen.Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class ControlProductos
    {
        public bool Guardar (Producto producto)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                if (producto.ProductoId==0);
                {
                    paso = Insertar(producto);
                }
                else
                {
                    paso = Modificar(producto);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        private bool Insertar (Producto producto)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Productos.Add(producto).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        private bool  Modificar (Producto producto)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Productos.Add(producto).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Producto Buscar (int Id)
        {
            Contexto db = new Contexto();
            Producto producto = new Producto();
            try
            {
                producto = db.Productos.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public bool Eliminar(int Id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Producto producto = new Producto();

            try
            {
                producto = db.Productos.Find();
                db.Entry(producto).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        } 
        
        public List<Producto> GetProductos(Expression<Func<Producto,bool>> expression)
        {
            List<Producto> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Productos.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
