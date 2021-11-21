using System;
using System.Collections.Generic;
using Library;
using Telegram.Bot;

namespace FINAL_WORK_PII_2021.src.Library.Class
{
    public class ServerBot
    {
        public void startEngines(){
            /// <summary>
            /// We create an instance of the ChatBot calling the method Instance of the class TelegramBot.
            /// </summary>
            /// <value>Instance the TelegramBot.</value>
            TelegramBot telegramBot = TelegramBot.Instance;
            Console.WriteLine($"Hola soy el Bot de P2, mi nombre es {telegramBot.BotName} y tengo el Identificador {telegramBot.BotId}");

            //Obtengo el cliente de Telegram
            ITelegramBotClient bot = telegramBot.Client;

            //Asigno un gestor de mensajes
            //bot.OnMessage += OnMessage;

            //Inicio la escucha de mensajes
            bot.StartReceiving();


            Console.WriteLine("Presiona una tecla para terminar");
            Console.ReadKey();

            //Detengo la escucha de mensajes 
            bot.StopReceiving();
        }
    }
}