using NUnit.Framework;

namespace RSA.Tests
{
    [TestFixture]
    public class RSATests
    {
        // Тест проходит успешно, поэтому остальные писать нет смысла
        // Поламается что-то, тогда уже
        public void MainTest()
        {
            var inputMessage = "MEssaGE MEssaGE MEssaGE MEssaGE MEssaGE.,/!";
            var crypto = new RSA();
            crypto.Calculate(crypto.P, crypto.Q);
            crypto.Encrypt(inputMessage);
            crypto.Decrypt(crypto.Cipher);

            Assert.AreEqual(inputMessage, crypto.OutputMessage);
            Assert.AreEqual(crypto.InputNumbers, crypto.OutputNumbers);
        }
    }
}
