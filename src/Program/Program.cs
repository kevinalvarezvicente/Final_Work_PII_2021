using Telegram.Bot.Types;
using System;
using src.Library.Class;
using System.Text.Json;
using src.Library.Class.Logic_Bot;
using src.Library.Class.Commands;
using Library;
using src.Library.Class.LoadList;

namespace src.Program
{
    public class Program
    {

        public static void Main(string[] args)
        {
            LoadList loadList = new LoadList();
            loadList.LoadAllLists();
            
            ServerBot bot = new ServerBot(); 
            bot.startEngines();
            
            Invitation invitation = new Invitation();
            invitation.GenerateInvitation("Kevin","Solutec");
            string json = invitation.ConvertToJson();
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"invitation.json", json);
        }
    }
}