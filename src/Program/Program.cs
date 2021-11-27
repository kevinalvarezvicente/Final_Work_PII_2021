using Telegram.Bot.Types;
using System;
using Ucu.Poo.Locations.Client;
using src.Library.Class;

namespace src.Program
{
    class Program
    {

        public static void Main()
        {
            ServerBot bot = new ServerBot(); 
            bot.startEngines();
            /*LocationApiClient client = new LocationApiClient();
            ICommand commandICommand =
                new HelloCommand(
                new LoginCommand(
                new InvitationCommand(
                new PublicationCommand(
                new UsernameCommand(
                new GoodByeCommand(null
                
            ))))));
            
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
            }*/
        }
    }
}