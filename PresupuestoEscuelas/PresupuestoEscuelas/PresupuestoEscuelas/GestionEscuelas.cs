using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class GestionEscuelas
    {
        private string _connectionString;

        public GestionEscuelas(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AgregarEscuela(Escuela escuela)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Escuela (Nombre, NumeroAlumnos) VALUES (@Nombre, @NumeroAlumnos)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", escuela.Nombre);
                command.Parameters.AddWithValue("@NumeroAlumnos", escuela.NumeroAlumnos);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void AgregarAlumno(string nombreEscuela, string nombreAlumno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Alumno (Nombre, EscuelaId) SELECT @NombreAlumno, Id FROM Escuela WHERE Nombre = @NombreEscuela";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreAlumno", nombreAlumno);
                command.Parameters.AddWithValue("@NombreEscuela", nombreEscuela);

                connection.Open();
                command.ExecuteNonQuery();

                query = @"UPDATE Escuela SET NumeroAlumnos = NumeroAlumnos + 1 WHERE Nombre = @NombreEscuela";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreEscuela", nombreEscuela);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public List<Escuela> ObtenerEscuelas()
        {
            List<Escuela> escuelas = new List<Escuela>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT Id, Nombre, NumeroAlumnos FROM Escuela";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int numeroAlumnos = reader.GetInt32(2);

                    escuelas.Add(new Escuela(id, nombre, numeroAlumnos));
                }

                connection.Close();
            }

            return escuelas;
        }
    }
}