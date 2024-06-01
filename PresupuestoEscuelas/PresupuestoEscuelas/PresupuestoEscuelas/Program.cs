using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestoEscuelas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



        string connectionString = "Server=DESKTOP-HB9L7EH\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Proyecto";
        //string connectionString = "Data Source=LAPTOP-P2NACEBG\\SQLEXPRESS;Initial Catalog=Proyecto;User ID=sa;Password=sarce123";

            BaseDatos baseDatos = new BaseDatos(connectionString);
            Autenticacion autenticacion = new Autenticacion(baseDatos);
            GestionUsuarios gestionUsuarios = new GestionUsuarios(baseDatos);
            GestionPresupuesto gestionPresupuesto = new GestionPresupuesto(connectionString);
            RegistroGastos registroGastos = new RegistroGastos(connectionString);
            GeneracionInformes generacionInformes = new GeneracionInformes(connectionString);

            FormularioAutenticacion formularioAutenticacion = new FormularioAutenticacion(autenticacion);

            Application.Run(formularioAutenticacion);
        }
    }
}