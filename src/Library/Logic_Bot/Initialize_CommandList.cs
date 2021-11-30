using src.Library.Class.Commands;
using src.Library.Class.Commands.StepsInvitation;

namespace src.Library.Class.Logic_Bot
{
    public class Initialize_CommandList
    {
        public static ICommand commandICommand;

        public void commandForNormalUser(){
            commandICommand =
                new HelloCommand(
                new InvitationCommand(
                new InvitationCommandStep1(
                new PublicationCommand(
                new MaterialCommand(
                new GoodByeCommand(null
            ))))));
        }

        public void commandForAdminUser(){
            commandICommand =
                new HelloCommand(
                new InvitationCommand(
                new InvitationCommandStep1(
                new PublicationCommand(
                new MaterialCommand(
                new GoodByeCommand(null
            ))))));
        }

        public Initialize_CommandList(){
            this.CommandICommand = commandICommand;
        }
    }
}