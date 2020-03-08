using Microsoft.EntityFrameworkCore;
using Parcial1.Data;
using Parcial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial1.Controllers
{
    public class InscripcionController
    {
        private bool Insertar(Inscripciones inscripciones)
        {
            Contexto db = new Contexto();
            bool paso = false;


            db.Inscripciones.Add(inscripciones);
            paso = db.SaveChanges() > 0;


            return paso;
        }



        public bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Inscripciones.Add(inscripciones);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public bool Modificar(Inscripciones inscripciones)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripciones.Add(inscripciones).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public bool Eliminar(int Matricula)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Inscripciones inscripcion = new Inscripciones();

            try
            {
                inscripcion = db.Inscripciones.Find(Matricula);
                db.Entry(inscripcion).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }
        

    }
}
