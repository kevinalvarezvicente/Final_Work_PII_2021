using Telegram.Bot.Types;

using src.Library.Class.Persistence.Lists;

namespace src.Library.Class.Commands.StepsInvitation
{
    public class InvitationCommandStep1 : BaseCommand
    {
        
        public InvitationCommandStep1(BaseCommand next) : base(next)
        {
        }

        /*
            Si el token que ingreso esta en nuestra base de datos, se indica que es valido.
        */        
        protected override bool InternalHandle(Message message, out string response)
        {
            Chat chatInfo = message.Chat;
            string answer = message.Text.ToString();

            if(List_UnsubscribeUser.findToken(message.Text)){
                response= "Token Correcto, Ingrese cualquier mensaje para continuar";
                return true;
            }
            else{
                response = "Token Incorrecto, Vuelva a intentarlo";
                return true;
            }
        }
    }
}