using Library;
using FINAL_WORK_PII_2021.src.Library.Class.Commands;
using Telegram.Bot.Types;
using System;
<<<<<<< HEAD
using PII_Proyecto_Final_TEMP.src.Library.Class;
using PII_Proyecto_Final_TEMP.src.Library.Class.Commands;
=======
>>>>>>> 95ae3b34721569ef86861e5d69de46ea77e6167c

namespace Library
{
    class Program
    {

        public static void Main()
        {
<<<<<<< HEAD
            /*LocationApiClient client = null;*/
            /*Invitation invit = new Invitation();
            invit.generateInvitation();*/
=======


            // Invitation invit = new Invitation();
            // invit.generateInvitation();
>>>>>>> 95ae3b34721569ef86861e5d69de46ea77e6167c
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
            }
        }
    }
}