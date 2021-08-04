using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
   public class Curso: BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AñoCalendario { get; set; }
        public int Cupo { get; set; }
        public Materia MiMateria { get; set; }
        public Comision MiComision { get; set; }
    }
}
