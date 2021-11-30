using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using src.Library;

namespace src.Library.Class.Commands

{
    public class GoodByeCommand : BaseCommand
    {
        /// <summary>
        /// Inicialize a new intance of the class <see cref="GoodByeCommand"/>. This class process the message "chau".
        /// </summary>
        /// <param name="next">The next "command".</param>
        public GoodByeCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "chau", "adiós" };
        }

        /// <summary>
        /// Process the message "chau" and it returns true; or false in the opposite case.
        /// </summary>
        /// <param name="message">The message to process</param>
        /// <param name="response">The answer to the message processed.</param>
        /// <returns>true if the message was processed; false in the opposite case.</returns>
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