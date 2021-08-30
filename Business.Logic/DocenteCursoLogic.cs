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

        public List<DocenteCurso> GetAllByDocente(int id)
        {
            return DocenteCursoData.GetAllByDocente(id);
        }

        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoData.GetOne(id);
        }

        public void Save(DocenteCurso docenteCurso)
        {
            DocenteCursoData.Save(docenteCurso);
        }

        public void Delete(int id)
        {
            DocenteCursoData.Delete(id);
        }
    }
}
