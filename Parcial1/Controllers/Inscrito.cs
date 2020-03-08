//using Microsoft.EntityFrameworkCore;
//using Parcial1.Data;
//using Parcial1.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Threading.Tasks;


//namespace Parcial1.Controllers
//{
//    public class Inscrito
//    {
//        public bool Guardar(Inscriciones inscribir)
//        {
//            Inscrito db = new Inscrito();
//            bool paso = false;

//            try
//            {
//                if (inscribir.Matricula==0)
//                {
//                    paso = Insertar(inscribir);
//                }
//                else
//                {
//                    paso = Modificar(inscribir);
//                }
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            return paso;
//        }

//        private bool Insertar(Inscrito inscrito)
//        {
//            Contexto db = new ;
//            bool paso = false;

//            db.Productos.Add();
//            paso = db.SaveChanges() > 0;

//            return paso;
//        }

//        private bool Modificar(Inscrito inscrito)
//        {
//            Contexto db = new Contexto();
//            bool paso = false;

//            db.Productos.Add(productos).State = EntityState.Modified;
//            paso = db.SaveChanges() > 0;

//            return paso;
//        }

//        public Inscrito Buscar(int id)
//        {
//            Contexto db = new Contexto();
//            Productos productos = new Productos();

//            try
//            {
//                productos = db.Productos.Find(id);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            return productos;
//        }

//        public bool Eliminar(int id)
//        {
//            Contexto db = new Contexto();
//            bool paso = false;
//            Productos productos = new Productos();

//            try
//            {
//                productos = db.Productos.Find(id);
//                db.Entry(productos).State = EntityState.Deleted;

//                paso = db.SaveChanges() > 0;
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//            return paso;
//        }

//        public List<Inscrito> GetProductos(Expression<Func<Inscrito, bool>> expression)
//        {
//            List<Productos> lista;
//            Contexto db = new Contexto();
//            try
//            {
//                lista = db.Productos.Where(expression).ToList();
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//            return lista;
//        }

//    }
//}
//    }
//}
