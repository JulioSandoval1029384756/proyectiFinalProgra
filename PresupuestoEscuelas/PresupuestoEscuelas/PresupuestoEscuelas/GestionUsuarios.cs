using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class GestionUsuarios
    {
        private BaseDatos _baseDatos;

        public GestionUsuarios(BaseDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            using (SqlConnection connection = _baseDatos.ObtenerConexion())
            {
                string query = "INSERT INTO Usuarios (Nombre, Email, Contraseña) VALUES (@Nombre, @Email, @Contraseña)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Usuario ObtenerUsuarioPorEmailYContraseña(string email, string contraseña)
        {
            using (SqlConnection connection = _baseDatos.ObtenerConexion())
            {
                string query = "SELECT Id, Nombre, Email, Contraseña FROM Usuarios WHERE Email = @Email AND Contraseña = @Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string emailUsuario = reader.GetString(2);
                    string contraseñaUsuario = reader.GetString(3);

                    return new Usuario(userId, nombre, emailUsuario, contraseñaUsuario);
                }

                connection.Close();
            }
            return null;
        }
    }
}