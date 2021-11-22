using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;
using Library;


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
                // if(UsernameCommand usuPass [0] == admin)
                //     {
                //      response = "¿Qué empresa quieres invitar?";
                //      Invitation invite = new Invitation();
                //      invite.generateInvitation();

                //      return true;
                //     }
                // else
                //     {
                //         response = "¿Escribe el código de invitacion que te enviamos por correo";
                //         return true;
                //     }
            }

            response = string.Empty;
            return false;
        }
    }
}