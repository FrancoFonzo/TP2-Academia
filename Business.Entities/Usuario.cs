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
                return MiPersona == null ? "" : MiPersona.Nombre;
            }
        }
        public string ApellidoPersona
        {
            get
            {
                return MiPersona == null ? "" : MiPersona.Apellido;
            }
        }
        public string EMailPersona
        {
            get
            {
                return MiPersona == null ? "" : MiPersona.EMail;
            }
        }

    }
}
