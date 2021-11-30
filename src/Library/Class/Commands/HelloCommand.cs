using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using src.Library.Class.Commands;
using src.Library.Class;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using src.Library.Class.Persistence.DataBase_Logic;
using src.Library.Class.Persistence.Lists;

namespace src.Library.Class.Commands
{
    public class HelloCommand : BaseCommand
    {
        /// <summary>
        /// Inicialize a new intance of the class <see cref="HelloCommand"/>.his class process the message "hola".
        /// </summary>
        /// <param name="next">The next "command".</param>
        public HelloCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "hola" };
        }

        /// <summary>
        /// Process the message "hola" and it returns true; or false in the opposite case.
        /// </summary>
        /// <param name="message">The message to process</param>
        /// <param name="response">The answer to the message processed.</param>
        /// <returns>true if the message was processed; false in the opposite case.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            Chat chatInfo = message.Chat;
            if (message.Text.ToLower().Trim().Equals("hola"))
            {
                string notRegistred = "Para poder seguirte ayudando debes de registrarte.\n Digita '/Registrame' : Para registrarse.";
                response = "¡Hola "+chatInfo.FirstName+" 👋! Me llamo Arthur 🧑‍💼. Que bueno que me hayas elegido para ser tu amigobot 💪, te ayudaré en lo que necesites desde ahora en más :). " + notRegistred;
                /// <summary>
                /// We create the object notSubscribeUser here according to the creator Pattern because this class is an expert of this type of object.
                /// </summary>
                NotSubscribeUser notSubscribeUser = new NotSubscribeUser(List_UnsubscribeUser.LastId(),"Telegram",chatInfo.Id.ToString());
                List_UnsubscribeUser.Instance.Add(notSubscribeUser);

                

                return true;
            }
            response = string.Empty;
            return false;
        }
    }
}