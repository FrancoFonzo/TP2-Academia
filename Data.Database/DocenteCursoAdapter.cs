using System.Collections.Generic;
using Business.Entities;
using System.Linq;
namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            using (AcademiaEntities db = new AcademiaEntities())
            {
                List<DocenteCurso> docentesCursos = new List<DocenteCurso>();
                var lstDocentesCursos = db.docentes_cursos;
                lstDocentesCursos?.ToList().ForEach(dc => docentesCursos.Add(nuevoDocenteCurso(dc)));
                return docentesCursos;
            }
        }

        private static DocenteCurso nuevoDocenteCurso(docentes_cursos doCu)
        {
            DocenteCurso docenteCurso = new DocenteCurso()
            {
                ID = doCu.id_dictado,
                MiDocente = personaData.GetOne(doCu.id_docente),
                MiCurso = cursoData.GetOne(doCu.id_curso)
        };
            return docenteCurso;
        }

        public DocenteCurso GetOne(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var docCur = db.docentes_cursos.SingleOrDefault(dc => dc.id_dictado == ID);
                if (docCur == null) return null;
                return nuevoDocenteCurso(docCur);
            }
        }


        public void Delete(int ID)
        {
            using (var db = new AcademiaEntities())
            {
                var docCur = db.docentes_cursos.SingleOrDefault(dc => dc.id_dictado == ID);
                if (docCur == null) return;
                db.docentes_cursos.Remove(docCur);
                db.SaveChanges();
            }
        }

        public void Save(DocenteCurso docenteCurso)
        {
            if (docenteCurso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(docenteCurso.ID);
            }
            else if (docenteCurso.State == BusinessEntity.States.New)
            {
                this.Insert(docenteCurso);
            }
            else if (docenteCurso.State == BusinessEntity.States.Modified)
            {
                this.Update(docenteCurso);
            }
            docenteCurso.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(DocenteCurso docenteCurso)
        {
            using (var db = new AcademiaEntities())
            {
                var docCur = db.docentes_cursos.SingleOrDefault(dc => dc.id_dictado == docenteCurso.ID);
                if (docCur == null) return;
                docCur.id_docente = docenteCurso.MiDocente.ID;
                docCur.id_curso = docenteCurso.MiCurso.ID;
                db.SaveChanges();
            }
        }

        protected void Insert(DocenteCurso docenteCurso)
        {
            using (var db = new AcademiaEntities())
            {
                docentes_cursos docCur = new docentes_cursos
                {
                    id_dictado = docenteCurso.ID,
                    id_docente = docenteCurso.MiDocente.ID,
                    id_curso = docenteCurso.MiCurso.ID
            };

                db.docentes_cursos.Add(docCur);
                db.SaveChanges();
            }
        }
    }
}
