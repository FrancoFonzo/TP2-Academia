using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AñoEspecialidad { get; set; }
        public Plan MiPlan { get; set; }
    }
}
