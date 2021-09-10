using Data.Database;
using System.Collections.Generic;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        public PlanAdapter PlanData { get; set; }

        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }

        public List<Entities.Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public Entities.Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public void Save(Entities.Plan plan)
        {
            PlanData.Save(plan);
        }
    }
}
