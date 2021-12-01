using Telegram.Bot.Types;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands
{
    public class RegisteredCommand : BaseCommand
    {
        public RegisteredCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Esta clase iniciaria los commandos de una Empresa registrada
        */
        protected override bool InternalHandle(Message message, out string response){
            response = "Su empresa esta registrada: " + MessageReceived.company.ToString();
            //Registrar en Json
            return true;
        }
    }
}