//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using Library;
using NUnit.Framework;
using PII_Proyecto_Final_TEMP.src.Library.Class;

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
        private Invitation invitation;

        /// <summary>
        /// Crea una invitacion.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            Token classtoken = new Token();
            Token token1 = new Token();
            token1 = classtoken.createToken(1);
            this.invitation = new Invitation(token1,"Pablo","Armando");
        }

    

        /// <summary>
        /// Prueba que se genere una invitacion.
        /// </summary>
        [Test]
        public void GenerateInvitationTest()
        {
            Assert.NotNull(this.invitation);
            this.invitation.generateInvitation("Pablo", "Armando");
            //Assert.True(this.invitation.generateInvitation);
        }
    }
}