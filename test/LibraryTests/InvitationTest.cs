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
    /// Prueba de la clase <see cref="Train"/>.
    /// </summary>
    [TestFixture]
    public class InvitationTest
    {
        /// <summary>
        /// El tren para probar.
        /// </summary>
        private Invitation invitation;

        /// <summary>
        /// Crea un tren para probar.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.invitation = new Invitation();
        }

        /// <summary>
        /// Prueba que el tren arranque.
        /// </summary>
        [Test]
        public void StartTrainTest()
        {
            Assert.NotNull(this.train);
            this.train.StartEngines();
            Assert.True(this.train.IsEngineStarted);
        }

        /// <summary>
        /// Prueba que el tren se detenga.
        /// </summary>
        [Test]
        public void StopTrainTest()
        {
            Assert.NotNull(this.train);
            this.train.StartEngines();
            this.train.StopEngines();
            Assert.False(this.train.IsEngineStarted);
        }
    }
}