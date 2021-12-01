using Telegram.Bot.Types;
using src.Library.Class.Logic_Bot;

namespace src.Library.Class.Commands
{
    public class DepartmentCommand : BaseCommand
    {
        public DepartmentCommand(BaseCommand next) : base(next)
        {
        }

        /*
            Este comando registra la localidad de la empresa en memoria. Este comando se activa si ya ingreso token, nombre, rut y  rubro de empres en memoria.
        */
        protected override bool InternalHandle(Message message, out string response)
        {
            if(MessageReceived.company.Department == null){
                MessageReceived.company.Department = message.Text;
                response = "Localidad de empresa registrado con exito, Su empresa ha sido registrada.";
                return true;
            }
            
            response = string.Empty;
            return false;
        }
    }
}