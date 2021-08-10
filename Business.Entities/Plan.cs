namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public string Descripcion { get; set; }
        public Especialidad MiEspecialidad { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
