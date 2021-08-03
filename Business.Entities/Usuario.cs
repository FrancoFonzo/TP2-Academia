namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public Persona MiPersona { get; set; }
        public bool Habilitado { get; set; }

        // Para Bind a dgvUsuarios
        public string NombrePersona
        {
            get
            {
                if (MiPersona == null) return "";
                return MiPersona.Nombre;
            }
        }
        public string ApellidoPersona
        {
            get
            {
                if (MiPersona == null) return "";
                return MiPersona.Apellido;
            }
        }
        public string EMailPersona
        {
            get
            {
                if (MiPersona == null) return "";
                return MiPersona.EMail;
            }
        }

    }
}
