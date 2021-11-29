using System;
using System.Collections.Generic;
using Library;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using src.Library.Class.Persistence.DataBase_Logic;

namespace src.Library.Class.Persistence.Lists
{
    public class List_UnsubscribeUser: IJsonConvertible
    {
        [JsonInclude]
        public List<NotSubscribeUser> ListNotSubscribeUser = new List<NotSubscribeUser>();
 
        private static List_UnsubscribeUser instance;

        [JsonConstructor]
        public List_UnsubscribeUser()
        {
            Initialize();
        }

        public void Initialize()
        {
            this.ListNotSubscribeUser = new List<NotSubscribeUser>();
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
            this.ListNotSubscribeUser.Add(user);
            this.save();
        }

        public void Remove(NotSubscribeUser user)
        {
            this.ListNotSubscribeUser.Remove(user);
        }

        private static JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };

        public string ConvertToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public void save(){
            string json = this.ConvertToJson();
            System.IO.File.WriteAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json", json);
        }

    }
}