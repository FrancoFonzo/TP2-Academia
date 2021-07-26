using System;
using System.Collections.Generic;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        public MateriasAdapter MateriasData { get; set; }

        public MateriaLogic()
        {
            this.MateriasData = new MateriasAdapter();
        }

        public Materias GetOne(int id)
        {
            return MateriasData.GetOne(id);
        }

        public List<Materias> GetAll()
        {
            return MateriasData.GetAll();
        }



        public void Save(Materias  materia)
        {
            MateriasData.Save(materia);
        }

        public void Delete(int id)
        {
            MateriasData.Delete(id);
        }

        
    }
}
