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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las materias.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la materia.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la materia.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la materia.", ex);
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
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la materia.", ex);
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
