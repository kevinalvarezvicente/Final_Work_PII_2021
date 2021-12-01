using Telegram.Bot.Types;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands
{
    public class CompanyNameCommand : BaseCommand
    {
        public CompanyNameCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Este comando registra el nombre de la empresa en memoria. Este comando se activa si ya ingreso un token y no hay un nombre de empres en memoria.
        */
        protected override bool InternalHandle(Message message, out string response)
        {
            if(MessageReceived.company.CompanyName == null){
                MessageReceived.company.CompanyName = message.Text;
                response = "Nombre de empresa registrado con exito, por favor ingrese Rut.";
                return true;
            }
            
            response = string.Empty;
            return false;
        }
    }
}