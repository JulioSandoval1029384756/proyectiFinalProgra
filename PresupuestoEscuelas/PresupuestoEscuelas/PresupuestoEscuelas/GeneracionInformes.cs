using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class GeneracionInformes
    {
        private string _connectionString;

        public GeneracionInformes(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Gasto> ObtenerInformeGastos(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Gasto> gastos = new List<Gasto>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Descripcion, Monto, Fecha FROM Gastos WHERE Fecha BETWEEN @FechaInicio AND @FechaFin";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@FechaFin", fechaFin);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   
                    string descripcion = reader.GetString(1);
                    decimal monto = reader.GetDecimal(2);
                    DateTime fecha = reader.GetDateTime(3);

                    gastos.Add(new Gasto(descripcion, monto, fecha));
                }

                connection.Close();
            }

            return gastos;
        }
    }
}
