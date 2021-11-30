using System;
using Telegram.Bot.Types;

namespace src.Library.Class.Commands
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
            // if (message.Text.ToLower().Equals("/admin-46587618"))
            // {
            //     response = "¿Qué empresa quieres invitar?";
            //     return true;
            // }
            if (message.Text.ToLower().Equals("/register"))
            {
                response = "prueba";
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}