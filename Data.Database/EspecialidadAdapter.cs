using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Especialidad.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las especialidades.", ex);
            }
        }

        public Especialidad GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Especialidad.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la especialidad.", ex);
            }
        }

        protected void Insert(Especialidad especialidad)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Especialidad.Add(especialidad);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la especialidad.", ex);
            }
        }

        protected void Update(Especialidad especialidad)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(especialidad).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la especialidad.", ex);
            }
        }

        public void Delete(Especialidad especialidad)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Especialidad.Remove(context.Especialidad.Find(especialidad.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la especialidad.", ex);
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Update(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
