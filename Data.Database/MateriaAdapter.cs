using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Materia.Include(m => m.Plan).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        public Materia GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Materia.Include(m => m.Plan).FirstOrDefault(m => m.ID == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
            }
        }

        protected void Insert(Materia materia)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Plan.Attach(materia.Plan);
                    context.Materia.Add(materia);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron insertar los datos", e);
            }
        }

        protected void Update(Materia materia)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(materia).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron actualizar los datos", e);
            }
        }

        public void Delete(Materia materia)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Materia.Remove(context.Materia.Find(materia.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se pudieron borrar los datos", e);
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.New)
            {
                Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Update(materia);
            }
            else if (materia.State == BusinessEntity.States.Deleted)
            {
                Delete(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
