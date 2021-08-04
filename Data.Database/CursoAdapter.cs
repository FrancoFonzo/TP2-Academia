using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<Curso> cursos = new List<Curso>();
                var lstCursos = db.cursos;
                lstCursos?.ToList().ForEach(c => cursos.Add(nuevoCurso(c)));
                return cursos;
            }
        }

        private Curso nuevoCurso(cursos cur)
        {
            Curso cursos = new Curso()
            {
                ID = cur.id_curso,
                Descripcion = cur.descripcion,
                AñoCalendario = cur.anio_calendario,
                Cupo = cur.cupo,
                MiMateria = materiaData.GetOne(cur.id_materia),
                MiComision= comisionData.GetOne(cur.id_comision)
            };
            return cursos;
        }



        public Curso GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var cur = db.cursos.SingleOrDefault(c => c.id_curso == ID);
                if (cur == null) return null;
                return nuevoCurso(cur);
            }

        }

        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var cur = db.cursos.SingleOrDefault(c => c.id_curso == ID);
                if (cur == null) return;
                db.Entry(cur).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Curso curso)
        {
            using (var db = new AcademiaEntities())
            {
                var cur = db.cursos.SingleOrDefault(c => c.id_curso == curso.ID);
                if (cur == null) return;
                cur.descripcion = curso.Descripcion;
                cur.anio_calendario = curso.AñoCalendario;
                cur.cupo = curso.Cupo;
                cur.id_materia = curso.MiMateria.ID;
                cur.id_comision = curso.MiComision.ID;
                db.SaveChanges();
            }
        }

        protected void Insert(Curso curso)
        {
            using (var db = new AcademiaEntities())
            {
                cursos cur = new cursos()
                {
                    id_curso = curso.ID,
                    descripcion = curso.Descripcion,
                    cupo = curso.Cupo,
                    anio_calendario = curso.AñoCalendario,
                    id_materia = curso.MiMateria.ID,
                    id_comision = curso.MiComision.ID
                };
                db.cursos.Add(cur);
                db.SaveChanges();
            }
        }
    }
}