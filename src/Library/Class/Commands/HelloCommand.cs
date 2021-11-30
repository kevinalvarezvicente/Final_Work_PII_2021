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
            Chat chatInfo = message.Chat;
            if (message.Text.ToLower().Trim().Equals("hola"))
            {
                string notRegistred = "Para poder seguirte ayudando debes de registrarte.\n Digita '/Registrame' : Para registrarse.";
                response = "¡Hola "+chatInfo.FirstName+" 👋! Me llamo Arthur 🧑‍💼. Que bueno que me hayas elegido para ser tu amigobot 💪, te ayudaré en lo que necesites desde ahora en más :). " + notRegistred;
                /// <summary>
                /// We create the object notSubscribeUser here according to the creator Pattern because this class is an expert of this type of objects.
                /// </summary>
                /// <returns></returns>
                /// 
                NotSubscribeUser notSubscribeUser = new NotSubscribeUser(List_UnsubscribeUser.LastId(),"Telegram",chatInfo.Id.ToString());
                List_UnsubscribeUser.Instance.Add(notSubscribeUser);

                return true;
            }
            response = string.Empty;
            return false;
        }
    }
}