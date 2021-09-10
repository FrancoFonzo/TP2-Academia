using System.Collections.Generic;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        public CursoAdapter CursoData { get; set; }

        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }

        public List<Curso> GetAllNoInscByPersona(int id)
        {
            return CursoData.GetAllNoInscByPersona(id);
        }

        public void Save(Curso curso)
        {
            CursoData.Save(curso);
        }
    }
}
