using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Escuela
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumeroAlumnos { get; set; }

        public Escuela(string nombre, int numeroAlumnos)
        {
            Nombre = nombre;
            NumeroAlumnos = numeroAlumnos;
        }

        public Escuela(int id, string nombre, int numeroAlumnos)
        {
            Id = id;
            Nombre = nombre;
            NumeroAlumnos = numeroAlumnos;
        }
    }
}