using Library;
using PII_Proyecto_Final_TEMP;

namespace Library
{
    public class Invitation
    {

        public Invitation()
        {
            idInvitation = "";
        }

        public string idInvitation { get; private set; }

        public Invitation createInvitation(int id)
        {
            Invitation invitation1 = new Invitation();
            invitation1.idInvitation = invitation1.generateInvitation(id);
            return invitation1;
        }

        public string generateInvitation(int id)
        {
            Token classtoken = new Token();
            classtoken.createToken(id);
            return classtoken.ToString();
        }
    }
}