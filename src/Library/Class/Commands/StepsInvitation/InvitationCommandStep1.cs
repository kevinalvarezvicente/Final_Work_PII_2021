using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;
using Library;
using src.Library.Class.Logic_Bot;
using src.Library.Class.Persistence.Lists;

namespace src.Library.Class.Commands.StepsInvitation
{
    public class InvitationCommandStep1 : BaseCommand
    {
        
        public InvitationCommandStep1(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/registrame" };
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            Chat chatInfo = message.Chat;
            string answer = message.Text.ToString();

            /*Invitation invit = List_Invitation.Instance.findInvitation(answer);*/

            response = "Estoy validando tu invitación " + chatInfo.FirstName;
            
            return true;     
        }
    }
}