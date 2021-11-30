using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;
using Library;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands
{
    public class InvitationCommand : BaseCommand
    {
        
        public InvitationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/registrame" };
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/registrame"))
            {
                response = "Para continuar necesito que me pases el token de invitación. Este token te lo debió de pasar uno de mis creadores por otro medio.";
                return true;     
            }

            response = string.Empty;
            return false;
        }
    }
}