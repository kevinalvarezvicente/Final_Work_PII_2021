using Library;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using src.Library.Class.Persistence.DataBase_Logic;

namespace src.Library.Class
{
    public class Invitation : IJsonConvertible
    {
        Token token;

        bool confirmInvitation;

         public int idInvitation { get; set; }
        public string guestName { get; set; }
        public string adminName { get; set; }
        public Token tokenInvitation { get; set; }
       

        public Invitation(){
            idInvitation = 0;
            tokenInvitation = null;
            guestName = "";
            adminName = "";
            confirmInvitation = false;
            ;
        }
        public void GenerateInvitation(string guestNameSend, string adminNameSend)
        {
            Token token = new Token();
            token.CreateToken();
            this.tokenInvitation = token;
            this.guestName = guestNameSend;
            this.adminName = adminNameSend;
        }

        public bool AcceptInvitation(Invitation invitation)
        {
            this.confirmInvitation = true;
            return true;
        }

        public string ConvertToJson()
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

    }
}