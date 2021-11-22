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
            this.Keywords = new string[] { "/invitacion" };
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/invitacion"))
            {
                // response = "¿Qué empresa quieres invitar?";
                // return true;
                if(message.Text.Equals("/admin-49281514"))
                    {
                     response = "¿Qué empresa quieres invitar?";
                    //  Invitation invite = new Invitation();
                    //  invite.generateInvitation();

                     return true;
                    }
                else
                    {
                        response = "Escribe el código de invitacion que te enviamos por correo";
                        return true;
                    }
            }

            response = string.Empty;
            return false;
        }
    }
}