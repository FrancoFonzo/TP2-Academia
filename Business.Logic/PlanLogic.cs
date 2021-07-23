using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        public PlanAdapter PlanData { get; set; }

        public PlanLogic()
        {
            this.PlanData = new PlanAdapter();
        }

        public Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public Plan GetOneNombreUsuario(string plan)
        {
            return PlanData.GetOneNombrePlan(plan);
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }

        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
