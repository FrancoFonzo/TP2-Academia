using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        public ModoForm Modo { get; set; }

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        };

        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
        public virtual void Listar() { }
        public virtual bool Validar() { return false; }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            Notificar(Text, mensaje, botones, icono);
        }

        protected bool IsRowSelected(DataGridView dgvSelected)
        {
            if (dgvSelected.SelectedRows.Count != 1)
            {
                Notificar("Acción invalida", "Porfavor seleccione una fila.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
