using RNG;
using RsaEncryptionTRNG;
namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void RSACheck()
        {

            string plainText = "123343";
            RSADESEncryption encryption = new();
            encryption.CreatingRSAKeys();
            var cipher = encryption.Encrypt(plainText);
            var decryptedText = encryption.Decrypt(cipher);




            Assert.True(plainText == decryptedText);
        }

        [Fact]
        public void RSAGoodSignatureCheck()
        {

            string plainText = "123343";
            RSADESEncryption encryption = new();
            encryption.CreatingRSAKeys();


            Assert.True(encryption.IsSignatureVerified(plainText));
        }

        [Fact]
        public void RSAWrongKeyCheck()
        {

            string plainText = "123343";
            RSADESEncryption encryption = new();
            encryption.CreatingRSAKeys();
            encryption.RSAPrivateKey.Exponent = new byte[] { 255, 254, 253 };


            Assert.False(encryption.IsSignatureVerified(plainText));
        }



    }
}