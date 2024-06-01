using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class PersonalEscuela : Usuario
    {
        private RegistroGastos _registroGastos;

        public PersonalEscuela(int id, string nombre, string email, string contraseña, RegistroGastos registroGastos)
            : base(id, nombre, email, contraseña)
        {
            _registroGastos = registroGastos;
        }

        public void RegistrarGasto(Gasto gasto)
        {
            _registroGastos.RegistrarGasto(gasto);
        }
    }
}
