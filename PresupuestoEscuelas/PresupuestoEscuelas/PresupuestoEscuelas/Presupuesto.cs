using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoAsignado { get; set; }
        public DateTime Fecha { get; set; }

        public Presupuesto(int id, decimal montoTotal, decimal montoAsignado, DateTime fecha)
        {
            Id = id;
            MontoTotal = montoTotal;
            MontoAsignado = montoAsignado;
            Fecha = fecha;
        }
    }
}
