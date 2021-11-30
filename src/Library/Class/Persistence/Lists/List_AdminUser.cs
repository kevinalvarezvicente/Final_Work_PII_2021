using System.Collections.Generic;
using Library;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using src.Library.Class.Persistence.DataBase_Logic;

namespace src.Library.Class.Persistence.Lists
{
    public class List_AdminUser{
        [JsonInclude]
        public static List<AdministratorUser> list_AdminUser = new List<AdministratorUser>();
 
        private static List_AdminUser instance;

        [System.Text.Json.Serialization.JsonConstructor]
        public List_AdminUser()
        {
            Initialize();
        }

        public void Initialize()
        {
            list_AdminUser = new List<AdministratorUser>();
        }

        public static List_AdminUser Instance
        {
            get{
                if (instance == null)
                {
                    instance = new List_AdminUser();
                }

                return instance;
            }
        }

        private static JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };

        public string ConvertToJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(list_AdminUser);
        }

        public void save(){
            string json = this.ConvertToJson();
            System.IO.File.WriteAllText(@"../Library/Class/Persistence/Data/Entidades/adminUser.json", json);
        }

        public List<AdministratorUser> Deserialize(){
            
            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/adminUser.json");
            list_AdminUser = System.Text.Json.JsonSerializer.Deserialize<List<AdministratorUser>>(jsonString, options);

            return list_AdminUser;
        }

        public void LoadList(){

            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/adminUser.json");
            if(jsonString != ""){
                list_AdminUser = System.Text.Json.JsonSerializer.Deserialize<List<AdministratorUser>>(jsonString, options);
            }
        }

        public static bool findId(string idUserReceived){
            AdministratorUser user = list_AdminUser.Find(x => (x.idUser == idUserReceived));
            if (user != null){
                return true;
            }else{
                return false;
            }
        }
    }
}