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
    public partial class FormularioAutenticacion : Form
    {
        private Autenticacion _autenticacion;

        public FormularioAutenticacion(Autenticacion autenticacion)
        {
            InitializeComponent();
            _autenticacion = autenticacion;
            textBoxEmail.Text = "mynor@gmail.com";
            textBoxContraseña.Text = "12345";
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string contraseña = textBoxContraseña.Text;

            Usuario usuario = _autenticacion.Autenticar(email, contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Autenticación exitosa. Bienvenido, " + usuario.Nombre);
                
                FormularioPrincipal formularioPrincipal = new FormularioPrincipal(usuario);
                formularioPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos.");
            }
        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void FormularioAutenticacion_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}