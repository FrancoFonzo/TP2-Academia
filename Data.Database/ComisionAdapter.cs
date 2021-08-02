using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Comision> comisiones = new List<Comision>();
                var lstComisiones = db.comisiones;
                lstComisiones?.ToList().ForEach(c => comisiones.Add(nuevaComision(c)));
                return comisiones;
            }
        }

        private Comision nuevaComision(comisiones com)
        {
            Comision comision = new Comision()
            {
                ID = com.id_comision,
                Descripcion = com.desc_comision,
                AñoEspecialidad = com.anio_especialidad,
                MiPlan = planData.GetOne(com.id_plan)
            };
            return comision;
        }



        public Comision GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var com = db.comisiones.SingleOrDefault(c => c.id_comision == ID);
                if (com == null) return null;
                return nuevaComision(com);
            }

        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var com = db.comisiones.SingleOrDefault(c => c.id_comision == ID);
                if (com == null) return;
                db.Entry(com).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Comision comisiones)
        {
            using (var db = new AcademiaEntities())
            {
                var com = db.comisiones.SingleOrDefault(c => c.id_comision == comisiones.ID);
                if (com == null) return;
                com.desc_comision = comisiones.Descripcion;
                com.anio_especialidad = comisiones.AñoEspecialidad;

                db.SaveChanges();
            }
        }

        protected void Insert(Comision comisiones)
        {
            using (var db = new AcademiaEntities())
            {
                comisiones com = new comisiones()
                {
                    id_comision = comisiones.ID,
                    desc_comision = comisiones.Descripcion,
                    anio_especialidad = comisiones.AñoEspecialidad
                };
                db.comisiones.Add(com);
                db.SaveChanges();
            }
        }
    }
}
