using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }

        public Usuario(int id, string nombre, string email, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Contraseña = contraseña;
        }
        public Usuario(string nombre, string email, string contraseña)
        {
            Nombre = nombre;
            Email = email;
            Contraseña = contraseña;
        }
    }
}