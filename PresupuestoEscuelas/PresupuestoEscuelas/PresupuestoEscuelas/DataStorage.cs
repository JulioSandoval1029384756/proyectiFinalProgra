using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public static class DataStorage
    {
        public static List<Escuela> Escuelas { get; set; } = new List<Escuela>();
        public static List<Gasto> Gastos { get; set; } = new List<Gasto>();
        public static List<Alimento> Alimentos { get; set; } = new List<Alimento>();
        public static decimal PresupuestoTotal { get; set; } = 0;
    }
}