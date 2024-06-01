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
    public partial class FormularioPrincipal : Form
    {
        private Usuario _usuario;

        public FormularioPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            labelBienvenida.Text = "Bienvenido, " + _usuario.Nombre;
        }

        private void buttonGestionarPresupuesto_Click(object sender, EventArgs e)
        {
            FormularioGestionPresupuesto formulario = new FormularioGestionPresupuesto();
            formulario.ShowDialog();
        }

        private void buttonRegistrarGasto_Click(object sender, EventArgs e)
        {
            FormularioRegistroGastos formulario = new FormularioRegistroGastos();
            formulario.ShowDialog();
        }

        private void buttonGestionEscuelas_Click(object sender, EventArgs e)
        {
            FormularioGestionEscuelas formulario = new FormularioGestionEscuelas();
            formulario.ShowDialog();
        }

        private void buttonRegistroAlimentos_Click(object sender, EventArgs e)
        {
            FormularioRegistroAlimentos formulario = new FormularioRegistroAlimentos();
            formulario.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}