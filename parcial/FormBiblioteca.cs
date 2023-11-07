using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        List<Libro> libros;
        List<Biblioteca> biblioteca;
        List<TimeSpan> TimeSpanList;

        public Form1()
        {
            InitializeComponent();
            this.libros = new List<Libro>();

            cmbGeneroLibro.DataSource = Enum.GetValues(typeof(Libro.Genero));

            libros.Add(new Libro { Nombre = "Harry Potter" });
            libros.Add(new Libro { Nombre = "Pulgarcito" });
            libros.Add(new Libro { Nombre = "1984" });
            cmbNombreLibro.DataSource = libros;

            this.libros = new List<Libro>();
            libros.Add(new Libro { Autor = "JK" });
            libros.Add(new Libro { Autor = "Grims" });
            libros.Add(new Libro { Autor = "Orwell" });
            cmbAutorLibro.DataSource = libros;

            this.libros = new List<Libro>();
            libros.Add(new Libro { Editorial = "Salamanca" });
            libros.Add(new Libro { Editorial = "DeBolsillo" });
            libros.Add(new Libro { Editorial = "Planeta" });
            cmbAutorLibro.DataSource = libros;

            TimeSpanList = new List<TimeSpan>();
            TimeSpanList.Add(new TimeSpan(8, 0, 0));
            TimeSpanList.Add(new TimeSpan(9, 0, 0));
            TimeSpanList.Add(new TimeSpan(6, 0, 0));
            cmbLanazamientoLibro.DataSource = TimeSpanList;




        }

        public bool ValidarDatos()
        {

            if (string.IsNullOrEmpty(cmbGeneroLibro.Text))
            {
                MessageBox.Show("Debe seleccionar un gENERO");
                return false;
            }
            if (string.IsNullOrEmpty(cmbEditorialLibro.Text))
            {
                MessageBox.Show("Debe seleccionar una Editorial");
                return false;
            }
            if (string.IsNullOrEmpty(cmbNombreLibro.Text))
            {
                MessageBox.Show("Debe seleccionar un Nombre");
                return false;
            }
            if (string.IsNullOrEmpty(cmbAutorLibro.Text))
            {
                MessageBox.Show("Debe seleccionar un Autor");
                return false;
            }
            return true;
        }

        private void dtp_LanazamientoLibro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {

        }
    }
}
