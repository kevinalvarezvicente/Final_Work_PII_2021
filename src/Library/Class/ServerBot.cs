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

namespace src.Library.Class
{
    public class ServerBot
    {
        public async void startEngines(){
            //Obtengo una instancia de TelegramBot
            Chatbot telegramBot = Chatbot.Instance;
            Console.WriteLine($"Hola soy el Bot de P2, mi nombre es {telegramBot.BotName} y tengo el Identificador {telegramBot.BotId}");

            //Obtengo el cliente de Telegram
            ITelegramBotClient bot = telegramBot.Client;

            //Asigno un gestor de mensajes
            bot.OnMessage += OnMessage;

            //Inicio la escucha de mensajes
            bot.StartReceiving();


            Console.WriteLine("Presiona una tecla para terminar");
            //Console.ReadKey();

            //Detengo la escucha de mensajes 
            bot.StopReceiving();
            
        }
            private static async void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            Message message = messageEventArgs.Message;
            Chat chatInfo = message.Chat;
            string messageText = message.Text.ToLower();
            if (messageText != null)
            {
                ITelegramBotClient client = Chatbot.Instance.Client;
                Console.WriteLine($"{chatInfo.FirstName}: envío {message.Text}");

                /*------------------------------------------------------------------*/
                ICommand commandICommand =
                new HelloCommand(
                new UsernameCommand(
                new LoginCommand(
                new InvitationCommand(
                new PublicationCommand(
                new MaterialCommand(
                new GoodByeCommand(null
            )))))));
            

                string response;

                    if (message.Text.Equals("salir", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("Salimos");
                        return;
                    }

                ICommand result = commandICommand.Handle(message, out response);
                    Console.WriteLine(result);
                    if (result == null)
                    {
                        Console.WriteLine("No entiendo");
                        Console.Write("> ");
                    }
                    else
                    {
                        await client.SendTextMessageAsync(
                                          chatId: chatInfo.Id,
                                          text: response);
                    }
                
                /*------------------------------------------------------------------*/
                
            }
        }



        }
    }
