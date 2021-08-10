using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<Materia> materias = new List<Materia>();
                var lstMaterias = context.materias;
                lstMaterias?.ToList().ForEach(m => materias.Add(nuevaMateria(m)));
                return materias;
            }
        }

        private Materia nuevaMateria(materias mat)
        {
            if (mat == null)
            {
                return null;
            }
            Materia materia = new Materia
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
            using (var context = new AcademiaEntities())
            {
                var mat = context.materias.SingleOrDefault(m => m.id_materia == ID);
                return nuevaMateria(mat);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var mat = context.materias.SingleOrDefault(m => m.id_materia == ID);
                if (mat != null)
                {
                    context.Entry(mat).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.New)
            {
                Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Materia materias)
        {
            using (var context = new AcademiaEntities())
            {
                var mat = context.materias.SingleOrDefault(m => m.id_materia == materias.ID);
                if (mat != null)
                {
                    mat.desc_materia = materias.Descripcion;
                    mat.hs_totales = materias.HorasTotales;
                    mat.hs_semanales = materias.HorasSemanales;

                    context.SaveChanges();
                }
            }
        }

        protected void Insert(Materia materias)
        {
            using (var context = new AcademiaEntities())
            {
                materias mat = new materias
                {
                    id_materia = materias.ID,
                    desc_materia = materias.Descripcion,
                    hs_semanales = materias.HorasSemanales,
                    hs_totales = materias.HorasTotales
                };
                context.materias.Add(mat);
                context.SaveChanges();
            }
        }
    }
}
