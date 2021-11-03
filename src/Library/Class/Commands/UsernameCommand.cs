using System;
using Telegram.Bot.Types;

namespace PII_Proyecto_Final_TEMP.src.Library.Class.Commands
{
    class UsernameCommand : BaseCommand
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="HelloHandler"/>. Esta clase procesa el mensaje "hola".
        /// </summary>
        /// <param name="next">El próximo "handler".</param>
        public UsernameCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "" };
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
            if (SMessage.Contains(',')) { 
                string[] usuPass= SMessage.Split(',');
                response = "Tu usuario es: " + usuPass[0] + "y tu contraseña es : " + usuPass[1];
            }
            response = "Datos erroneos";
            return true;
        }
    }
}