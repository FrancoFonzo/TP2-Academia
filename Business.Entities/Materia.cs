using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia: BusinessEntity
    { 
        public string Descripcion { get; set; }
        public int HorasSemanales { get; set; }
        public int HorasTotales { get; set; }
        public Plan MiPlan { get; set; }
    }
}
