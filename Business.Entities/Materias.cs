using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materias: BusinessEntity
    { 
        public string descMateria { get; set; }
        public int hs_semanales { get; set; }
        public int hs_totales { get; set; }
        public int ID_plan { get; set; }
        
        
    }
}
