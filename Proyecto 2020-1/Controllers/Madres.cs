﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_2020_1.Data;
using Proyecto_2020_1.Models;

namespace Proyecto_2020_1.Controllers
{
    public class Madres
    {
        public static bool Guardar (Granja entity)
        {
            GranjaContexto granaContexto = new GranjaContexto();
            bool paso = false;
            
            try
            {
                if (granaContexto.granjas.Any(A => A.MadreId == entity.MadreId))
                {
                    paso = Modificar(entity);
                }
                else
                {
                    paso = Insertar(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                granaContexto.Dispose();
            }
            return paso;
            
        }


        private static bool Modificar (Granja entyti)
        {
            GranjaContexto granaContexto = new GranjaContexto();
            bool paso = false;

            try
            {
                granaContexto.Entry(entyti).State = EntityState.Modified;                               
                    paso = granaContexto.SaveChanges() > 0;
                 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                granaContexto.Dispose();
            }
            return paso;
        }

        private static bool Insertar(Granja entity)
        {
            GranjaContexto granaContexto = new GranjaContexto();
            bool paso = false;

            try
            {
                granaContexto.granjas.Add(entity);
                paso = granaContexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                granaContexto.Dispose();
            }

            return paso;
        }
    }
}
