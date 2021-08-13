using System.Collections.Generic;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        public ComisionAdapter ComisionData { get; set; }

        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }

        public void Save(Comision comision)
        {
            ComisionData.Save(comision);
        }

        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }
    }
}
