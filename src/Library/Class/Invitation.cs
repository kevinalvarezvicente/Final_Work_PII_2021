using Library;
using PII_Proyecto_Final_TEMP.src.Library.Class;

namespace Library
{
    public class Invitation
    {
        string nombreInvitado;
        string nombreAdministrador;
        Token token;

        public string NombreInvitado { get; set; }
        public string NombreAdministrador { get; set; }
        public Token Token1 { get; set; }

        public Invitation(Token token, string nombreInvitado, string nombreAdministrador){
            this.Token1 = token;
            this.NombreInvitado = nombreInvitado;
            this.NombreAdministrador = nombreAdministrador;
        }
        public bool generateInvitation(string nombreInvitadoEnviado, string nombreAdministradorEnviado)
        {
            Token ClassToken = new Token();
            Token token1 = new Token();
            token1 = ClassToken.createToken(1);
            Invitation invitacion = new Invitation(token1,nombreInvitadoEnviado,nombreAdministradorEnviado);
            return true;
        }
    }
}