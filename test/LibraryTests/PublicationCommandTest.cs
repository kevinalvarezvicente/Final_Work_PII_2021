using System.Windows.Input;
using NUnit.Framework;
using Ucu.Poo.TelegramBot;
using Telegram.Bot.Types;

namespace ProgramTests
{
    public class PublicationCommandTests
    {
        PublicationCommand command;
        Message message;

        [SetUp]
        public void Setup()
        {
            command = new PublicationCommand(null);
            message = new Message();
        }

        [Test]
        public void TestCommand()
        {
            message.Text = command.Keywords[0];
            string response;

            ICommand result = command.Command(message, out response);

            Assert.That(result, Is.Not.Null);
            Assert.That(response, Is.EqualTo("Nombre de la publicacion?"));
        }

        [Test]
        public void TestDoesNotHandle()
        {
            message.Text = "publicar";
            string response;

            ICommand result = command.Command(message, out response);

            Assert.That(result, Is.Null);
            Assert.That(response, Is.Empty);
        }
    }
}