using NUnit.Framework;


namespace Project.Tests
{
    [TestFixture]

    public class AdministratorUserTest
    {
        [Test]
        public void TestInvite()
        {
            AdministratorUser admin = new AdministratorUser();
            admin = new AdmisitratorUset.Invite(1);
            token = new Token.generateToken();
            Assert.AreEqual(token,admin);
        }
    }
}