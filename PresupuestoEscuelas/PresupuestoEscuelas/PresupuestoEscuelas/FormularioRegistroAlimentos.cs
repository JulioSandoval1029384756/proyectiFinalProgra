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
    public partial class FormularioRegistroAlimentos : Form
    {
        public FormularioRegistroAlimentos()
        {
            InitializeComponent();
        }

        private void buttonGuardarAlimento_Click(object sender, EventArgs e)
        {
            string nombreAlimento = textBoxNombreAlimento.Text;
            decimal precio;
            if (decimal.TryParse(textBoxPrecioAlimento.Text, out precio))
            {
                Alimento alimento = new Alimento { Nombre = nombreAlimento, Precio = precio };
                DataStorage.Alimentos.Add(alimento);
                MessageBox.Show("Alimento registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
            }
        }
    }
}