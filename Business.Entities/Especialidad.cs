namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        public string Descripcion { get; set; }

        // Para Bind a DataGridView
        public override string ToString()
        {
            return Descripcion;
        }

    }
}
