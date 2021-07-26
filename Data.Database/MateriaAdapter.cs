using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Materia> materias = new List<Materia>();
                var lstMaterias = db.materias;
                lstMaterias?.ToList().ForEach(m => materias.Add(nuevaMateria(m)));
                return materias;
            }
        }

        private Materia nuevaMateria(materias mat)
        {
            Materia materia = new Materia()
            {
                ID = mat.id_materia,
                Descripcion = mat.desc_materia,
                HorasSemanales = mat.hs_semanales,
                HorasTotales = mat.hs_totales,
                MiPlan = planData.GetOne(mat.id_plan)
            };
            return materia;
        }



        public Materia GetOne(int ID)
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

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Materia materias)
        {
            using (var db = new AcademiaEntities())
            {
                var mat = db.materias.SingleOrDefault(m => m.id_materia == materias.ID);
                if (mat == null) return;
                mat.desc_materia = materias.Descripcion;
                mat.hs_totales = materias.HorasTotales;
                mat.hs_semanales = materias.HorasSemanales;

                db.SaveChanges();
            }
        }

        protected void Insert(Materia materias)
        {
            using (var db = new AcademiaEntities())
            {
                materias mat = new materias()
                {
                    id_materia = materias.ID,
                    desc_materia = materias.Descripcion,
                    hs_semanales = materias.HorasSemanales,
                    hs_totales = materias.HorasTotales
                };
                db.materias.Add(mat);
                db.SaveChanges();
            }
        }
    }
}
