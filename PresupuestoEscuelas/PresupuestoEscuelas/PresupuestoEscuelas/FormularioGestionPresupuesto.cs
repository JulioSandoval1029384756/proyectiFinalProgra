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
    public partial class FormularioGestionPresupuesto : Form
    {
        private GestionPresupuesto _gestionPresupuesto;
        public FormularioGestionPresupuesto()
        {
            InitializeComponent();
            _gestionPresupuesto = new GestionPresupuesto("Server=DESKTOP-HB9L7EH\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Proyecto");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            decimal montoTotal;
            if (decimal.TryParse(textBoxMontoTotal.Text, out montoTotal))
            {
                DataStorage.PresupuestoTotal = montoTotal;
                MessageBox.Show("Presupuesto guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
            }
        }

        private void labelMontoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
