using Telegram.Bot.Types;

namespace src.Library.Class.Commands
{
    public class InvitationCommand : BaseCommand
    {
        
        public InvitationCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Si el usuario selecciono /registrame se le solicita un token.
        */
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