using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class GestionPresupuesto
    {
        private string _connectionString;
        private BaseDatos baseDatos;

        public GestionPresupuesto(string connectionString)
        {
            _connectionString = connectionString;
        }

        public GestionPresupuesto(BaseDatos baseDatos)
        {
            this.baseDatos = baseDatos;
        }

        public void AsignarPresupuesto(Presupuesto presupuesto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Presupuesto (MontoTotal, MontoAsignado, Fecha) VALUES (@MontoTotal, @MontoAsignado, @Fecha)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MontoTotal", presupuesto.MontoTotal);
                command.Parameters.AddWithValue("@MontoAsignado", presupuesto.MontoAsignado);
                command.Parameters.AddWithValue("@Fecha", presupuesto.Fecha);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void ActualizarPresupuesto(Presupuesto presupuesto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Presupuestos SET MontoTotal = @MontoTotal, MontoAsignado = @MontoAsignado, Fecha = @Fecha WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", presupuesto.Id);
                command.Parameters.AddWithValue("@MontoTotal", presupuesto.MontoTotal);
                command.Parameters.AddWithValue("@MontoAsignado", presupuesto.MontoAsignado);
                command.Parameters.AddWithValue("@Fecha", presupuesto.Fecha);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Presupuesto ObtenerPresupuestoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, MontoTotal, MontoAsignado, Fecha FROM Presupuesto WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int presupuestoId = reader.GetInt32(0);
                    decimal montoTotal = reader.GetDecimal(1);
                    decimal montoAsignado = reader.GetDecimal(2);
                    DateTime fecha = reader.GetDateTime(3);

                    return new Presupuesto(presupuestoId, montoTotal, montoAsignado, fecha);
                }

                connection.Close();
                return null; 
            }
        }
    }
}
