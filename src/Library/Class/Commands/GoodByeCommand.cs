using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using src.Library;

namespace src.Library.Class.Commands

{
    public class GoodByeCommand : BaseCommand
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="GoodByeCommand"/>. Esta clase procesa el mensaje "chau"
        /// y el mensaje "adiós"
        /// </summary>
        /// <param name="next">El próximo "command".</param>
        public GoodByeCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "chau", "adiós" };
        }

        /// <summary>
        /// Procesa el mensaje "chau" y retorna true; retorna false en caso contrario.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            if (this.CanHandle(message))
            {
                response = "¡Chau! ¡Qué andes bien!";
                return true;
            }

            response = string.Empty;
            return false;
        }

    }
}