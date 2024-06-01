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
    public partial class FormularioRegistroGastos : Form
    {
        public FormularioRegistroGastos()
        {
            InitializeComponent();
        }

        private void buttonGuardarGasto_Click(object sender, EventArgs e)
        {
            string descripcion = textBoxDescripcion.Text;
            decimal monto;
            if (decimal.TryParse(textBoxMonto.Text, out monto))
            {
                Gasto gasto = new Gasto(descripcion, monto, DateTime.Now);
                DataStorage.Gastos.Add(gasto);
                MessageBox.Show("Gasto registrado.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
            }
        }
    }
}