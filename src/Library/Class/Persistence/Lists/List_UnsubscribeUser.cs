using System;
using System.Collections.Generic;
using Library;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using src.Library.Class.Persistence.DataBase_Logic;
using src.Library.Class.Persistence.Save;
namespace src.Library.Class.Persistence.Lists
{
    public class List_UnsubscribeUser: IJsonConvertible{
        public List<NonActiveUser> nonActiveUser = new List<NonActiveUser>();
 
        private static List_UnsubscribeUser instance;

        private List_UnsubscribeUser()
        {
            Initialize();
        }

        public void Initialize()
        {
            this.nonActiveUser = new List<NonActiveUser>();
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

        public void Add(NonActiveUser user)
        {
            this.nonActiveUser.Add(user);
            Save_UnsubscribeUser Class_Save_UnsubscribeUser = new Save_UnsubscribeUser();
            Class_Save_UnsubscribeUser.save(this.nonActiveUser);
        }

        public void Remove(NonActiveUser user)
        {
            this.nonActiveUser.Remove(user);
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