using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Comision> comisiones = new List<Comision>();
                var lstComisiones = context.comisiones;
                lstComisiones?.ToList().ForEach(c => comisiones.Add(nuevaComision(c)));
                return comisiones;
            }
        }

        private Comision nuevaComision(comisiones com)
        {
            if (com == null)
            {
                return null;
            }
            Comision comision = new Comision
            {
                ID = com.id_comision,
                Descripcion = com.desc_comision,
                AnioEspecialidad = com.anio_especialidad,
                MiPlan = planData.GetOne(com.id_plan)
            };
            return comision;
        }



        public Comision GetOne(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var com = context.comisiones.SingleOrDefault(c => c.id_comision == ID);
                return nuevaComision(com);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var com = context.comisiones.SingleOrDefault(c => c.id_comision == ID);
                if (com != null)
                {
                    context.Entry(com).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Comision comisiones)
        {
            using (var context = new AcademiaEntities())
            {
                var com = context.comisiones.SingleOrDefault(c => c.id_comision == comisiones.ID);
                if (com != null)
                {
                    com.desc_comision = comisiones.Descripcion;
                    com.anio_especialidad = comisiones.AnioEspecialidad;

                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Comision comisiones)
        {
            using (var context = new AcademiaEntities())
            {
                comisiones com = new comisiones
                {
                    id_comision = comisiones.ID,
                    desc_comision = comisiones.Descripcion,
                    anio_especialidad = comisiones.AnioEspecialidad
                };
                context.comisiones.Add(com);
                context.SaveChanges();
            }
        }
    }
}
