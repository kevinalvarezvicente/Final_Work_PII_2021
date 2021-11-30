using src.Library.Class.Commands;
using src.Library.Class.Commands.StepsInvitation;

namespace src.Library.Class.Logic_Bot
{
    public class Initialize_CommandList
    {

        public ICommand CommandICommand { get; set; }

        public ICommand commandICommand =
                new HelloCommand(
                new InvitationCommand(
                new InvitationCommandStep1(
                new PublicationCommand(
                new MaterialCommand(
                new GoodByeCommand(null
        ))))));

        public Initialize_CommandList(){
            this.CommandICommand = commandICommand;
        }
    }
}