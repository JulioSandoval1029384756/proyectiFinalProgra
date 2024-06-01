using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Administrador : Usuario
    {
        private GestionPresupuesto _gestionPresupuesto;

        public Administrador(int id, string nombre, string email, string contraseña, GestionPresupuesto gestionPresupuesto)
            : base(id, nombre, email, contraseña)
        {
            _gestionPresupuesto = gestionPresupuesto;
        }

        public void AsignarPresupuesto(Presupuesto presupuesto)
        {
            _gestionPresupuesto.AsignarPresupuesto(presupuesto);
        }
    }
}
