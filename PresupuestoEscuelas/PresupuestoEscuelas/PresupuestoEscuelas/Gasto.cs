using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Gasto
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Gasto(int id, string descripcion, decimal monto, DateTime fecha)
        {
            
            Descripcion = descripcion;
            Monto = monto;
            Fecha = fecha;
        }

        public Gasto(string descripcion, decimal monto, DateTime fecha)
        {
            Descripcion = descripcion;
            Monto = monto;
            Fecha = fecha;
        }
    }
}