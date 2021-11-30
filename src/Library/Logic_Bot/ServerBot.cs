using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using src.Library.Class.Commands;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace src.Library.Class.Logic_Bot
{
    public class ServerBot
    {
        public static ITelegramBotClient bot;
        /// <summary>
        /// This method start the listening of the bot
        /// </summary>
        /// <returns></returns>
        public async void startEngines(){
            /// <summary>
            /// It creates an instance of the bot.
            /// </summary>
            /// <param name="telegramBot">The instance of the bot</param>
            Chatbot telegramBot = Chatbot.Instance;
            /// <summary>
            /// Shows that the bot are running on console.
            /// </summary>
            Console.WriteLine($"Hola soy Arthur, tengo el Identificador {telegramBot.BotId}. Es un gusto saludarlo mi creador.");
            
            /// <summary>
            /// It creates an instance of the client that send a message.
            /// </summary>
            /// <param name="bot">The instance of the client</param>

            bot = telegramBot.Client;
            /// <summary>
            /// If a new message is received it will be sended to the class messageReceived to process it.
            /// </summary>
            bot.OnMessage += MessageReceived.OnMessage;

            /// <summary>
            /// Open listening.
            /// </summary>
            bot.StartReceiving();

            Console.WriteLine("Presiona una tecla para terminar");
            Console.ReadKey();
            /// <summary>
            /// Close listening
            /// </summary>
            bot.StopReceiving();
            
        }
        
    }
}