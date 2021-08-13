using System.Collections.Generic;
using Business.Entities;
using System.Linq;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            using (AcademiaEntities context = new AcademiaEntities())
            {
                List<DocenteCurso> docentesCursos = new List<DocenteCurso>();
                context.docentes_cursos
                    .ToList()
                    .ForEach(dc => docentesCursos.Add(NuevoDictado(dc)));
                return docentesCursos;
            }
        }

        //TODO: Se usara para Registro Notas
        public List<DocenteCurso> GetAllDocente(int id)
        {
            using (var context = new AcademiaEntities())
            {
                List<DocenteCurso> dictados = new List<DocenteCurso>();
                context.docentes_cursos.Where(i => i.id_docente == id)
                    .ToList()
                    .ForEach(i => dictados.Add(NuevoDictado(i)));
                return dictados;
            }
        }

        public DocenteCurso GetOne(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var docCur = context.docentes_cursos.FirstOrDefault(dc => dc.id_dictado == id);
                return NuevoDictado(docCur);
            }
        }

        public void Delete(int id)
        {
            using (var context = new AcademiaEntities())
            {
                var docCur = context.docentes_cursos.FirstOrDefault(dc => dc.id_dictado == id);
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
                var docCur = context.docentes_cursos.FirstOrDefault(dc => dc.id_dictado == docenteCurso.ID);
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

        private static DocenteCurso NuevoDictado(docentes_cursos dc)
        {
            if (dc == null)
            {
                return null;
            }
            DocenteCurso dictado = new DocenteCurso
            {
                ID = dc.id_dictado,
                MiDocente = personaData.GetOne(dc.id_docente),
                MiCurso = cursoData.GetOne(dc.id_curso)
            };
            return dictado;
        }
    }
}
