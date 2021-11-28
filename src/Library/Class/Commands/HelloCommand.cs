using Telegram.Bot.Types;

namespace src.Library.Class.Commands
{
    public class HelloCommand : BaseCommand
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="HelloCommand"/>. Esta clase procesa el mensaje "hola".
        /// </summary>
        /// <param name="next">El próximo "command".</param>
        public HelloCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "hola" };
        }

        /// <summary>
        /// Procesa el mensaje "hola" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Trim().Equals("hola"))
            {
                response = "¡Hola! Bienvenido a nuestro chat bot \n /Login: Para loguearte \n /Invitacion: Para registrarte \n /Publicar: Para publicar";

                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}