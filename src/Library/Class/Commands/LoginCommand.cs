using Telegram.Bot.Types;

namespace src.Library.Class.Commands
{
    public class LoginCommand : BaseCommand
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="LoginCommand"/>. Esta clase procesa el mensaje "/login".
        /// </summary>
        /// <param name="next">El próximo "command".</param>
        public LoginCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/login" };
        }

        /// <summary>
        /// Procesa el mensaje "/login" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/login"))
            {
                response = "Veo que no estas logueado :( , pero no te preocupes. \n Digita tu usuario y contraseña de la siguiente manera ´usuario,contraseña´ ";
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}
