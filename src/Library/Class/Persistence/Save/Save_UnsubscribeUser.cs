using System;
using src.Library.Class.Persistence.Lists;
namespace src.Library.Class.Persistence.Save
{
    public class Save_UnsubscribeUser{
        public void save(List_UnsubscribeUser list){
            Console.WriteLine(List_UnsubscribeUser.Instance);
            string json = list.ConvertToJson();
            System.IO.File.WriteAllText(@"../Library/Class/Persistence/Data/Entidades/unsubscribeActiveUser.json", json);
        }
    }
}
