
using Telegram.Bot.Types;
using src.Library.Class.Logic_Bot;


namespace src.Library.Class.Commands
{
    public class ToRegisterCommand : BaseCommand
    {

        public ToRegisterCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Si no existe una empresa en memoria se crea y se solicita un nombre para la empresa.
        */
        protected override bool InternalHandle(Message message, out string response)
        {
            if (MessageReceived.company == null){
                MessageReceived.company = new Company(null,null,null,null);
                response = "Ingrese un nombre para la empresa";
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}