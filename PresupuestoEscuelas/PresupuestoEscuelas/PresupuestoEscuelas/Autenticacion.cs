using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Autenticacion
    {
        private BaseDatos _baseDatos;

        public Autenticacion(BaseDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public Usuario Autenticar(string email, string contraseña)
        {
            using (SqlConnection connection = _baseDatos.ObtenerConexion())
            {
                string query = @"SELECT Id, Nombre, Email, Contraseña FROM Usuario WHERE Email = @Email AND Contraseña = @Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string emailUsuario = reader.GetString(2);
                    string contraseñaUsuario = reader.GetString(3);

                    
                    return new Usuario(id, nombre, emailUsuario, contraseñaUsuario);
                }

                connection.Close();
            }
            return null;
        }
    }
}
