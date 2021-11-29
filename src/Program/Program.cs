using Telegram.Bot.Types;
using System;
using Ucu.Poo.Locations.Client;
using src.Library.Class;
using src.Library.Class.Commands;

namespace src.Program
{
    class Program
    {

        public static void Main()
        {
            ServerBot bot = new ServerBot(); 
            bot.startEngines();
        }
    }
}