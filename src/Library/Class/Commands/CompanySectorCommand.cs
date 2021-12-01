using Telegram.Bot.Types;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands
{
    public class CompanySectorCommand : BaseCommand
    {
        public CompanySectorCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Este comando registra el rubro de la empresa en memoria. Este comando se activa si ya ingreso token, nombre, rut y no hay un rubro en memoria.
        */
        protected override bool InternalHandle(Message message, out string response)
        {
            if(MessageReceived.company.CompanySector == null){
                MessageReceived.company.CompanySector = message.Text;
                response = "Rubro de empresa registrado con exito, por favor ingrese Localidad de la empresa.";
                return true;
            }
            
            response = string.Empty;
            return false;
        }
    }
}