using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;
using Library;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands.StepsInvitation
{
    public class InvitationCommandStep2 : BaseCommand
    {
        
        public InvitationCommandStep2(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/registrame" };
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            Chat chatInfo = message.Chat;
            string answer = message.Text.ToString();
            response = "Estoy validando tu invitación " + chatInfo.FirstName;
            
            return true;     
        }
    }
}