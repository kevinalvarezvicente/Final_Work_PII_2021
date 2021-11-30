using System.Windows.Input;
using NUnit.Framework;
using Ucu.Poo.TelegramBot;
using src.Library.Class.Commands;

namespace ProgramTests
{
    public class HelloCommandTests
    {
        HelloCommand command;
        Message message;

        [SetUp]
        public void Setup()
        {
            command = new HelloCommand(null);
            message = new Message();
        }

        [Test]
        public void TestHandle()
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

            ICommand result = command.Handle(message, out response);

            Assert.That(result, Is.Null);
            Assert.That(response, Is.Empty);
        }
    }
}