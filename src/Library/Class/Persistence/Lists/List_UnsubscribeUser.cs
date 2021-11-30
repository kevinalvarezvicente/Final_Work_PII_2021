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
            ListNotSubscribeUser.Add(user);
            this.save();
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
            
            //La linea de abajo no devuelve al txt es solo el url
            string jsonString = System.IO.File.ReadAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json");
            ListNotSubscribeUser = System.Text.Json.JsonSerializer.Deserialize<List<NotSubscribeUser>>(jsonString, options);

            return ListNotSubscribeUser;
        }

        public static int LastId(){
            int userId = ListNotSubscribeUser.Last().IdUser + 1;
            return userId;
        }
    }
}