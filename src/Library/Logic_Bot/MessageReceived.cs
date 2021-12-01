using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace src.Library.Class.Logic_Bot
{
    public class MessageReceived
    {
        public ITelegramBotClient Client { get; set; }

        public static Initialize_CommandList commands = new Initialize_CommandList();

        public static bool hasToken = false;
        public static bool isReqistered = false;
        public static Company company = null;
        public static ICommand commandICommand(){
            if (isReqistered)
                return commands.registered;
            else
                if (hasToken)
                    return commands.toRegister;
                else
                    return commands.notRegistered;

        }        
        public MessageReceived(ITelegramBotClient client){
            this.Client = client;
        }

        public static async void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            /// <summary>
            /// It shares the event ocurred in the variable message
            /// </summary>
            /// <param name="message">The message received.</param>
            Message message = messageEventArgs.Message;

            /// <summary>
            /// It stores the chat information on chatinfo.
            /// </summary>
            /// <param name="chatInfo">The information of the chat stored .</param>
            Chat chatInfo = message.Chat;
            
            /// <summary>
            /// It eliminates the capital letters on the message received.
            /// </summary>
            /// <param name="messageText">The message received without capital letters.</param>
            string messageText = message.Text.ToLower();
            
            if (messageText != null)
            {
                /// <summary>
                /// It identifies the user that are talking with the bot
                /// </summary>
                /// <param name="client">The information of the client.</param>
                ITelegramBotClient client = Chatbot.Instance.Client;

                Console.WriteLine($"{chatInfo.FirstName}: envío {message.Text}");

                /// <param name="response">The response that the bot will send.</param>
                string response;

                ICommand result = commandICommand().Handle(message, out response);

                if (result == null)
                {
                    Console.WriteLine("No entiendo");
                    Console.Write("> ");
                }
                else
                {
                    if (response == "Token Correcto, Ingrese cualquier mensaje para continuar")
                        hasToken= true;
                    if (response == "Localidad de empresa registrado con exito, Su empresa ha sido registrada.")
                        isReqistered= true;
                    await client.SendTextMessageAsync(
                        chatId: chatInfo.Id,
                        text: response);
                }
            }
        }
    }
}