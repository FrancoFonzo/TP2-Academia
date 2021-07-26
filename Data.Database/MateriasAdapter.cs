using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class MateriasAdapter : Adapter
    {
        public List<Materias> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Materias> materias = new List<Materias>();
                var lstMaterias = db.materias;
                lstMaterias?.ToList().ForEach(m => materias.Add(nuevaMateria(m)));
                return materias;
            }
        }

        private Materias nuevaMateria(materias mat)
        {
            Materias materias = new Materias()
            {
                ID = mat.id_materia,
                descMateria = mat.desc_materia,
                hs_semanales = mat.hs_semanales,
                hs_totales = mat.hs_totales,
            };
            return materias;
        }



        public Materias GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var mat = db.materias.SingleOrDefault(m => m.id_materia == ID);
                if (mat == null) return null;
                return nuevaMateria(mat);
            }

        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var mat = db.materias.SingleOrDefault(m => m.id_materia == ID);
                if (mat == null) return;
                db.Entry(mat).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Save(Materias materias)
        {
            if (materias.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materias.ID);
            }
            else if (materias.State == BusinessEntity.States.New)
            {
                this.Insert(materias);
            }
            else if (materias.State == BusinessEntity.States.Modified)
            {
                this.Update(materias);
            }
            materias.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Materias materias)
        {
            using (var db = new AcademiaEntities())
            {
                var mat = db.materias.SingleOrDefault(m => m.id_materia == materias.ID);
                if (mat == null) return;
                mat.desc_materia = materias.descMateria;
                mat.hs_totales = materias.hs_totales;
                mat.hs_semanales = materias.hs_semanales;

                db.SaveChanges();
            }
        }

        protected void Insert(Materias materias)
        {
            using (var db = new AcademiaEntities())
            {
                materias mat = new materias()
                {
                    id_materia = materias.ID,
                    desc_materia = materias.descMateria,
                    hs_semanales = materias.hs_semanales,
                    hs_totales = materias.hs_totales
                };
                db.materias.Add(mat);
                db.SaveChanges();
            }
        }
    }
}
