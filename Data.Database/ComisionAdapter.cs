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
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
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
            catch (Exception e)
            {
                throw new Exception("No se pudieron recuperar los datos", e);
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
            catch (Exception e)
            {
                throw new Exception("No se pudieron insertar los datos", e);
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
            catch (Exception e)
            {
                throw new Exception("No se pudieron actualizar los datos", e);
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
            catch (Exception e)
            {
                throw new Exception("No se pudieron borrar los datos", e);
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
