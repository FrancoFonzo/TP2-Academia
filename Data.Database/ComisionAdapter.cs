using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System;


namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            try
            {
                using (AcademiaContext context = new AcademiaContext())
                {
                    return context.Comision.Include(c => c.Plan).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las comisiones.", ex);
            }
        }

        public Comision GetOne(int id)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    return context.Comision.Include(c => c.Plan).FirstOrDefault(c => c.ID == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la comision.", ex);
            }
        }

        protected void Insert(Comision comision)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Plan.Attach(comision.Plan);
                    context.Comision.Add(comision);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la comision.", ex);
            }
        }

        protected void Update(Comision comision)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Entry(comision).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar las comisiones.", ex);
            }
        }

        public void Delete(Comision comision)
        {
            try
            {
                using (var context = new AcademiaContext())
                {
                    context.Comision.Remove(context.Comision.Find(comision.ID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la comision.", ex);
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {
                Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
