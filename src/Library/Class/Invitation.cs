using Library;
using PII_Proyecto_Final_TEMP.src.Library.Class;

namespace Library
{
    public class Invitation
    {
        Token token;

        bool confirmInvitation;

        public string guestName { get; set; }
        public string AdminName { get; set; }
        public Token Token1 { get; set; }

        public Invitation(Token token, string guestName, string AdminName){
            this.Token1 = token;
            this.guestName = guestName;
            this.AdminName = AdminName;
            confirmInvitation = false;
        }
        public bool generateInvitation(string guestNameSend, string AdminNameSend)
        {
            Token classToken = new Token();
            classToken = classToken.createToken(1);
            Invitation invitation = new Invitation(classToken, guestNameSend, AdminNameSend);
            return true;
        }

        public bool acceptInvitation(Invitation invitation)
        {
            this.confirmInvitation = true;
            return true;
        }
    }
}