using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class RegistroGastos
    {
        private readonly string _connectionString;

        public RegistroGastos(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RegistrarGasto(Gasto gasto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Gastos (Descripcion, Monto, Fecha) VALUES (@Descripcion, @Monto, @Fecha)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", gasto.Descripcion);
                command.Parameters.AddWithValue("@Monto", gasto.Monto);
                command.Parameters.AddWithValue("@Fecha", gasto.Fecha);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Gasto> ObtenerGastos()
        {
            List<Gasto> gastos = new List<Gasto>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Descripcion, Monto, Fecha FROM Gastos";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);
                        decimal monto = reader.GetDecimal(2);
                        DateTime fecha = reader.GetDateTime(3);

                        Gasto gasto = new Gasto(id, descripcion, monto, fecha);
                        gastos.Add(gasto);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }

            return gastos;
        }
    }
}