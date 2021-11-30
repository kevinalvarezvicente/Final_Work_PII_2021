using System;
using System.Collections.Generic;
using Library;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using src.Library.Class.Persistence.DataBase_Logic;
using Newtonsoft.Json;
using System.IO;

namespace src.Library.Class.Persistence.Lists
{
    public class List_UnsubscribeUser{
        [JsonInclude]
        public static List<NotSubscribeUser> ListNotSubscribeUser = new List<NotSubscribeUser>();
 
        private static List_UnsubscribeUser instance;

        [System.Text.Json.Serialization.JsonConstructor]
        public List_UnsubscribeUser()
        {
            Initialize();
        }

        public void Initialize()
        {
            ListNotSubscribeUser = new List<NotSubscribeUser>();
        }

        public static List_UnsubscribeUser Instance
        {
            get{
                if (instance == null)
                {
                    instance = new List_UnsubscribeUser();
                }

                return instance;
            }
        }

        public void Add(NotSubscribeUser user)
        {
            bool find = findToken(user.Token);
            if(find == false){
                ListNotSubscribeUser.Add(user);
                this.save();
            }
        }

        public void Remove(NotSubscribeUser user)
        {
            ListNotSubscribeUser.Remove(user);
        }

        private static JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };

        public string ConvertToJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(ListNotSubscribeUser);
        }

        public void save(){
            string json = this.ConvertToJson();
            System.IO.File.WriteAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json", json);
        }

        public List<NotSubscribeUser> Deserialize(){
            
            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json");
            ListNotSubscribeUser = System.Text.Json.JsonSerializer.Deserialize<List<NotSubscribeUser>>(jsonString, options);

            return ListNotSubscribeUser;
        }

        public void LoadList(){

            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json");
            if(jsonString != ""){
                ListNotSubscribeUser = System.Text.Json.JsonSerializer.Deserialize<List<NotSubscribeUser>>(jsonString, options);
            }
        }

        public static int LastId(){
            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json");
            if (jsonString != ""){
                int userId = ListNotSubscribeUser.Last().IdUser + 1;
                return userId;
            }else{
                return 0;
            }
            
        }

        public static bool findToken(string token){
            NotSubscribeUser user = ListNotSubscribeUser.Find(x => (x.Token == token));
            if (user != null){
                return true;
            }else{
                return false;
            }
        }
    }
}