using Library;
using NUnit.Framework;
using src.Library.Class;

namespace Tests
{
    /// <summary>
    /// Prueba de la clase <see cref="Invitation"/>.
    /// </summary>
    [TestFixture]
    public class InvitationTest
    {
        /// <summary>
        /// La invitacion a probar
        /// </summary>
        private Invitation invitationT;

        /// <summary>
        /// Crea una invitacion.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            Token classtoken = new Token();
            Token token1 = new Token();
            token1 = classtoken.createToken(1);
            this.invitationT = new Invitation(token1,"Pablo","Armando");
        }

    

        /// <summary>
        /// Prueba que se genere una invitacion.
        /// </summary>
        [Test]
        public void GenerateInvitationTest()
        {
            Assert.NotNull(this.invitationT);
            this.invitationT.generateInvitation("Pablo", "Armando");
            Assert.IsTrue(this.invitationT.generateInvitation("Pablo", "Armando"));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void acceptInvitation()
        {
            Assert.NotNull(this.invitationT);
            this.invitationT.acceptInvitation(this.invitationT);
            Assert.IsTrue(this.invitationT.acceptInvitation(this.invitationT));
        }

    }
}