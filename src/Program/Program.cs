using Library;
using Telegram.Bot.Types;
using System;
using PII_Proyecto_Final_TEMP.src.Library.Class;
using PII_Proyecto_Final_TEMP.src.Library.Class.Commands;

namespace Library
{
    class Program
    {

        public static void Main()
        {
            /*LocationApiClient client = null;*/
            /*Invitation invit = new Invitation();
            invit.generateInvitation();*/
            ICommand commandICommand =
                new HelloCommand(
                new LoginCommand(
                new UsernameCommand(
                new GoodByeCommand(null
                
            ))));
            Message message = new Message();
            string response;

            Console.WriteLine("Escribí un comando o 'salir':");
            Console.Write("> ");

            while (true)
            {
                message.Text = Console.ReadLine();
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
                    Console.WriteLine(response);
                    Console.Write("> ");
                }
            }
        }
    }
}