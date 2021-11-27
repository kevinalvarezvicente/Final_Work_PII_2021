using System;
using Telegram.Bot.Types;

namespace FINAL_WORK_PII_2021.src.Library.Class.Commands
{
    public class UsernameCommand : BaseCommand
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UsernameCommand"/>. Esta clase procesa el usuario y password ingresada por el usuario.
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public UsernameCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/register" };
        }

        /// <summary>
        /// Procesa el mensaje "hola" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            String SMessage = message.Text.ToString();
            if (SMessage.Contains("/register")) { 
                string[] usuPass= SMessage.Split(',');
                response = "Tu usuario es: " + usuPass[0] + " y tu contraseña es : " + usuPass[1];
                return true;
            } 
            else 
            {
                response = "Datos erroneos";
                return false;
            }
            
        }
    }
}