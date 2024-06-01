using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EscuelaId { get; set; }

        public Alumno(string nombre, int escuelaId)
        {
            Nombre = nombre;
            EscuelaId = escuelaId;
        }

        public Alumno(int id, string nombre, int escuelaId)
        {
            Id = id;
            Nombre = nombre;
            EscuelaId = escuelaId;
        }
    }
}