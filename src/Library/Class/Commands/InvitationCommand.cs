using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;


namespace FINAL_WORK_PII_2021.src.Library.Class.Commands
{
    public class InvitationCommand : BaseCommand
    {
        
        public InvitationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/invitation" };
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/invitation"))
            {
                response = "¿Qué empresa quieres invitar?";
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}