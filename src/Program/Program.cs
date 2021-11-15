using Library;
using Telegram.Bot.Types;
using System;
using Ucu.Poo.Locations.Client;

namespace Final_Work_PII_2021
{
    class Program
    {

        public static void Main()
        {
            LocationApiClient client = null;
            /*Invitation invit = new Invitation();
            invit.generateInvitation();*/
            ICommand commandICommand =
                new HelloCommand(
                new LoginCommand(
                new UsernameCommand(
                new GoodByeCommand(
                
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