namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        public Usuario()
        {
            MiPersona = new Persona();
        }

        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool Habilitado { get; set; }

        #region Propiedades de Navegacion
        public Persona MiPersona { get; set; }
        #endregion

        #region Propiedades Auxiliares/DataPropertyName
        public string NombrePersona
        {
            get
            {
                return MiPersona.Nombre ?? "";
            }
        }

        public string ApellidoPersona
        {
            get
            {
                return MiPersona.Apellido ?? "";
            }
        }
        public string EMailPersona
        {
            get
            {
                return MiPersona.EMail ?? "";
            }
        }
        #endregion

    }
}
