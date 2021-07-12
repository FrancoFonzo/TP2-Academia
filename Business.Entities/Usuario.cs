using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        //public int? ID_Persona { get; set; }
        public Persona MiPersona { get; set; }
        public bool Habilitado { get; set; }

        // Propiedades para bindear a columnas de dgvUsuarios (alguna otra manera?)
        public string NombrePersona { get { return MiPersona.Nombre; } }
        public string ApellidoPersona { get { return MiPersona.Apellido; } }
        public string EMailPersona { get { return MiPersona.EMail; } }

    }
}
