using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoEscuelas
{
    public class Notificaciones
    {
        public void EnviarNotificacion(string mensaje, string destinatario)
        {
            try
            {
               
                SmtpClient smtpClient = new SmtpClient("smtp.example.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("tu_correo@example.com", "tu_contraseña"),
                    EnableSsl = true
                };

                
                MailMessage mailMessage = new MailMessage("tu_correo@example.com", destinatario)
                {
                    Subject = "Notificación de Presupuesto Escolar",
                    Body = mensaje
                };

              
                smtpClient.Send(mailMessage);

                Console.WriteLine("Notificación enviada por correo electrónico a: " + destinatario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar la notificación: " + ex.Message);
            }
        }
    }
}
