namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool Habilitado { get; set; }

        #region Propiedades de Navegacion
        public int? PersonaId { get; set; }
        private Persona _persona;
        public virtual Persona Persona
        {
            get
            {
                return _persona;
            }
            set
            {
                _persona = value;
                if (value == null)
                {
                    PersonaId = null;
                }
                else
                {
                    PersonaId = value.ID;
                }
            }
        }
        #endregion

        #region Propiedades Auxiliares/DataPropertyName
        public string PersonaNombre
        {
            get
            {
                return Persona?.Nombre ?? "-";
            }
        }

        public string PersonaApellido
        {
            get
            {
                return Persona?.Apellido ?? "-";
            }
        }
        public string PersonaEMail
        {
            get
            {
                return Persona?.EMail ?? "-";
            }
        }
        #endregion

    }
}
