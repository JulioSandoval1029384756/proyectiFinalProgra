using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestoEscuelas
{
    public partial class FormularioGestionEscuelas : Form
    {
        private GestionEscuelas _gestionEscuelas;

        public FormularioGestionEscuelas()
        {
            InitializeComponent();
            _gestionEscuelas = new GestionEscuelas("Server=DESKTOP-HB9L7EH\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Proyecto");
            CargarEscuelas();
        }

        private void CargarEscuelas()
        {
            listBoxEscuelas.Items.Clear();
            List<Escuela> escuelas = _gestionEscuelas.ObtenerEscuelas();
            foreach (Escuela escuela in escuelas)
            {
                listBoxEscuelas.Items.Add($"{escuela.Nombre} - {escuela.NumeroAlumnos} alumnos");
            }
        }

        private void buttonRegistrarEscuela_Click(object sender, EventArgs e)
        {
            string nombreEscuela = textBoxNombreEscuela.Text;
            int numeroAlumnos = 0; 

            if (!string.IsNullOrEmpty(nombreEscuela))
            {
                Escuela escuela = new Escuela(nombreEscuela, numeroAlumnos);
                _gestionEscuelas.AgregarEscuela(escuela);
                CargarEscuelas();
                MessageBox.Show("Escuela registrada.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de escuela.");
            }
        }

        private void buttonRegistrarAlumno_Click(object sender, EventArgs e)
        {
            string nombreAlumno = textBoxNombreAlumno.Text;
            if (!string.IsNullOrEmpty(nombreAlumno) && listBoxEscuelas.SelectedItem != null)
            {
                string escuelaSeleccionada = listBoxEscuelas.SelectedItem.ToString();
                string nombreEscuela = escuelaSeleccionada.Split('-')[0].Trim();

                _gestionEscuelas.AgregarAlumno(nombreEscuela, nombreAlumno);
                CargarEscuelas();
                MessageBox.Show("Alumno registrado.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una escuela e ingrese un nombre de alumno.");
            }
        }
    }
}