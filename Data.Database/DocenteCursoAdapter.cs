using System.Collections.Generic;
using Business.Entities;
using System.Linq;
using System;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<DocenteCurso> docentesCursos = new List<DocenteCurso>();
                var lstDocentesCursos = context.docentes_cursos;
                lstDocentesCursos?.ToList().ForEach(dc => docentesCursos.Add(nuevoDictado(dc)));
                return docentesCursos;
            }
        }

        internal IList<DocenteCurso> GetAllDocente(Persona docente)
        {
            using (var context = new AcademiaEntities())
            {
                IList<DocenteCurso> dictados = new List<DocenteCurso>();
                var lstDictados = context.docentes_cursos.Where(i => i.id_docente == docente.ID);
                lstDictados?.ToList().ForEach(i => dictados.Add(nuevoDictado(i, docente)));
                return dictados;
            }
        }

        public DocenteCurso GetOne(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var docCur = context.docentes_cursos.SingleOrDefault(dc => dc.id_dictado == ID);
                return nuevoDictado(docCur);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaEntities())
            {
                var docCur = context.docentes_cursos.SingleOrDefault(dc => dc.id_dictado == ID);
                if (docCur != null)
                {
                    context.docentes_cursos.Remove(docCur);
                    context.SaveChanges();
                }
            }
        }

        public void Save(DocenteCurso docenteCurso)
        {
            if (docenteCurso.State == BusinessEntity.States.Deleted)
            {
                Delete(docenteCurso.ID);
            }
            else if (docenteCurso.State == BusinessEntity.States.New)
            {
                Insert(docenteCurso);
            }
            else if (docenteCurso.State == BusinessEntity.States.Modified)
            {
                Update(docenteCurso);
            }
            docenteCurso.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(DocenteCurso docenteCurso)
        {
            using (var context = new AcademiaEntities())
            {
                var docCur = context.docentes_cursos.SingleOrDefault(dc => dc.id_dictado == docenteCurso.ID);
                if (docCur != null)
                {
                    docCur.id_docente = docenteCurso.MiDocente.ID;
                    docCur.id_curso = docenteCurso.MiCurso.ID;
                    context.SaveChanges();
                }
            }
        }

        protected void Insert(DocenteCurso docenteCurso)
        {
            using (var context = new AcademiaEntities())
            {
                docentes_cursos docCur = new docentes_cursos
                {
                    id_dictado = docenteCurso.ID,
                    id_docente = docenteCurso.MiDocente.ID,
                    id_curso = docenteCurso.MiCurso.ID
                };
                context.docentes_cursos.Add(docCur);
                context.SaveChanges();
            }
        }

        private static DocenteCurso nuevoDictado(docentes_cursos dc, Persona docente = null)
        {
            if (dc == null)
            {
                return null;
            }
            DocenteCurso dictado = new DocenteCurso
            {
                ID = dc.id_dictado,
                MiDocente = docente ?? personaData.GetOne(dc.id_docente),
                MiCurso = cursoData.GetOne(dc.id_curso)
            };
            return dictado;
        }
    }
}
