using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public especialidad MiEspecialidad { get; set; }

    }
}
