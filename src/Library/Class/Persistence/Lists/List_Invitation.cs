using System.Collections.Generic;
using Library;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using src.Library.Class.Commands.StepsInvitation;

namespace src.Library.Class.Persistence.Lists
{
    public class List_Invitation{
        [JsonInclude]
        public static List<Invitation> list_Invitations = new List<Invitation>();
 
        private static List_Invitation instance;

        [System.Text.Json.Serialization.JsonConstructor]
        public List_Invitation()
        {
            Initialize();
        }

        public void Initialize()
        {
            list_Invitations = new List<Invitation>();
        }

        public static List_Invitation Instance
        {
            get{
                if (instance == null)
                {
                    instance = new List_Invitation();
                }

                return instance;
            }
        }

        public void Add(Invitation invitation)
        {
            bool find = findInvitation(invitation.tokenInvitation.numberToken);
            if(find == false){
                list_Invitations.Add(invitation);
                this.save();
            }
        }

        public void Remove(Invitation invitation)
        {
            list_Invitations.Remove(invitation);
        }

        private static JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };

        public string ConvertToJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(list_Invitations);
        }

        public void save(){
            string json = this.ConvertToJson();
            System.IO.File.WriteAllText(@"../Library/Class/Persistence/Data/Entidades/invitation_List.json", json);
        }

        public List<Invitation> Deserialize(){
            
            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/invitation_List.json");
            list_Invitations = System.Text.Json.JsonSerializer.Deserialize<List<Invitation>>(jsonString, options);

            return list_Invitations;
        }

        public void LoadList(){

            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/invitation_List.json");
            if(jsonString != ""){
                list_Invitations = System.Text.Json.JsonSerializer.Deserialize<List<Invitation>>(jsonString, options);
            }
        }

        public static int LastId(){
            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json");
            if (jsonString != ""){
                int userId = list_Invitations.Last().idInvitation + 1;
                return userId;
            }else{
                return 0;
            }
            
        }

        public static bool findInvitation(string invitationTokenReceived){
            Invitation invit = list_Invitations.Find(x => (x.tokenInvitation.numberToken == invitationTokenReceived));
            if (invit != null){
                return true;
            }else{
                return false;
            }
        }
    }
}