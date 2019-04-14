using NUnit.Framework;

namespace RSA.Tests
{
    [TestFixture]
    public class RSATests
    {
        public void MainTest()
        {
            var inputMessage = "MEssaGE";
            var crypto = new RSA(inputMessage);

            Assert.AreEqual(inputMessage, crypto.OutputMessage);
            Assert.AreEqual(crypto.InputNumbers, crypto.OutputNumber);
        }
    }
}
