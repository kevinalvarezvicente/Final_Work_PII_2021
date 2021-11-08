using Library;
using PII_Proyecto_Final_TEMP.src.Library.Class;
using PII_Proyecto_Final_TEMP.src.Library.Class.Commands;
using PII_Proyecto_Final_TEMP.src.Library;
using System;
using System.IO;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Ucu.Poo.Locations.Client;
using MySql.Data.MySqlClient.Memcached;

namespace Final_Work_PII_2021
{
    class Program
    {

        public static void Main()
        {
            LocationApiClient client = null;
            /*Invitation invit = new Invitation();
invit.generateInvitation();*/
            ICommand handler =
                new HelloCommand(
                new LoginCommand(
                new UsernameCommand(
                new GoodByeCommand(
                new AddressHandler(new AddressFinder(client),
                new DistanceHandler(new DistanceCalculator(client), null
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

                ICommand result = handler.Handle(message, out response);
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