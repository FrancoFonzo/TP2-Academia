using System.Collections.Generic;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
