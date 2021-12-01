using src.Library.Class.Commands;
using src.Library.Class.Commands.StepsInvitation;

namespace src.Library.Class.Logic_Bot
{
    public class Initialize_CommandList
    {

        public ICommand CommandICommand { get; set; }

        public ICommand notRegistered =
                new HelloCommand(
                new InvitationCommand(
                new InvitationCommandStep1((null
        ))));

        public ICommand registered =
                new RegisteredCommand(null);
        public ICommand toRegister =
                new ToRegisterCommand( new CompanyNameCommand(new RutCommand(new CompanySectorCommand(new DepartmentCommand(null)))));

        public Initialize_CommandList(){
        }
    }
}