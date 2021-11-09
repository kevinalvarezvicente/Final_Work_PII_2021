using Library;
using NUnit.Framework;
using Telegram.Bot.Types;

namespace ProgramTests
{
    public class HelloHandlerTests
    {
        HelloCommand handler;
        Message message;

        [SetUp]
        public void Setup()
        {
            command = new HelloCommand(null);
            message = new Message();
        }

        [Test]
        public void TestCommand()
        {
            message.Text = command.Keywords[0];
            string response;

            ICommand result = command.Handle(message, out response);

            Assert.That(result, Is.Not.Null);
            Assert.That(response, Is.EqualTo("¡Hola! ¿Cómo estás?"));
        }

        [Test]
        public void TestDoesNotHandle()
        {
            message.Text = "adios";
            string response;

            ICommand result = handler.Handle(message, out response);

            Assert.That(result, Is.Null);
            Assert.That(response, Is.Empty);
        }
    }
}