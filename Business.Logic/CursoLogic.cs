using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic: BusinessLogic
    {
        public CursoAdapter CursoData { get; set; }

        public CursoLogic()
        {
            this.CursoData = new CursoAdapter();
        }

        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public void Save(Curso curso)
        {
            CursoData.Save(curso);
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
    }
}
