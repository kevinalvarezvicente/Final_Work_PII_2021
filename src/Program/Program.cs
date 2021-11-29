using Telegram.Bot.Types;
using System;
using Ucu.Poo.Locations.Client;
using src.Library.Class;
using System.Text.Json;
using System.IO;
using src.Library.Class.Commands;
using Library;

namespace src.Program
{
    public class Program
    {

        public static void Main(string[] args)
        {
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