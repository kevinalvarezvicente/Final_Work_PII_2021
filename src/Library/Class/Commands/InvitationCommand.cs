using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;
using Library;


namespace src.Library.Class.Commands
{
    public class InvitationCommand : BaseCommand
    {
        
        public InvitationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "hola" };
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/invitacion"))
            {
                response = "Para continuar necesito que me pases el token de invitación";
                string answer = message.Text.ToString();
                
                return true;     
            }

            response = string.Empty;
            return false;
        }
    }
}