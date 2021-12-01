using Telegram.Bot.Types;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands
{
    public class RutCommand : BaseCommand
    {
        public RutCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Este comando registra el rut de la empresa en memoria. Este comando se activa si ya ingreso token y nombre y no hay un rut de empres en memoria.
        */
        protected override bool InternalHandle(Message message, out string response)
        {
            if(MessageReceived.company.rut == null){
                MessageReceived.company.rut = message.Text;
                response = "Rut de empresa registrado con exito, por favor ingrese Rubro de la empresa.";
                return true;
            }
            
            response = string.Empty;
            return false;
        }
    }
}