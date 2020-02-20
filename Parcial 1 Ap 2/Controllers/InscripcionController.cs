using Microsoft.EntityFrameworkCore;
using Parcial_1_Ap_2.Data;
using Parcial_1_Ap_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial_1_Ap_2.Controllers
{
    public class InscripcionController
    {
        public bool Guardar(Inscripcion Inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (Inscripcion.InscripcionId == 0)
                {
                    paso = Insertar(Inscripcion);
                }
                else
                {
                    paso = Modificar(Inscripcion);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Inscripcion Inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripcion.Add(Inscripcion);
            paso = db.SaveChanges() > 0;

            return paso;
        }

        private bool Modificar(Inscripcion Inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripcion.Add(Inscripcion).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Inscripcion Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return inscripcion;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
                db.Entry(inscripcion).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public List<Inscripcion> GetInscripcion(Expression<Func<Inscripcion, bool>> expression)
        {
            List<Inscripcion> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Inscripcion.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}

