using Entidades;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormLibro : Form
    {
        private bool modifica = false;
        private Libro libros;
        List<TimeSpan> TimeSpanList;
        public FormLibro()
        {
            InitializeComponent();
            TimeSpanList = new List<TimeSpan>();
            TimeSpanList.Add(new TimeSpan(8, 0, 0));
            TimeSpanList.Add(new TimeSpan(8, 30, 0));
            cmbLanzamientoLihro.DataSource = TimeSpanList;

            this.libros = new Libro();
            this.libros.Add(new Libro( Autor = "Pulgarcito");
            cmbAutorLibro.DataSources = libros;


        }

        private void cmbAutorLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLanzamientoLihro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}