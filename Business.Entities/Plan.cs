using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public int ID_Plan { get; set; }
        public string Descripcion { get; set; }
        public int ID_Especialidad { get; set; }
        public Plan MiPlan { get; set; }

        public int ID_Plan
        {
            get
            {
                if (MiPlan == null) return "";
                return MiPlan.ID_Plan;
            }
        }
        public string Descripcion
        {
            get
            {
                if (MiPlan == null) return "";
                return MiPlan.Descripcion;
            }
        }
        public int ID_Especialidad
        {
            get
            {
                if (MiPlan == null) return "";
                return MiPlan.ID_Especialidad;
            }
        }

    }
}
