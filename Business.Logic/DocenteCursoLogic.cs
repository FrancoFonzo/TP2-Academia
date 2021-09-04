using System.Collections.Generic;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursoLogic : BusinessLogic
    {
        public DocenteCursoAdapter DocenteCursoData { get; set; }

        public DocenteCursoLogic()
        {
            DocenteCursoData = new DocenteCursoAdapter();
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }

        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoData.GetOne(id);
        }

        public void Save(DocenteCurso docenteCurso)
        {
            DocenteCursoData.Save(docenteCurso);
        }
    }
}
