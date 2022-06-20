using RNG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RsaEncryptionTRNG
{
    public class RSADESEncryption
    {
        byte[]? DesKey;
        byte[]? DesIV;
        const int RSAKEYLENGTH = 2048;


        public RSAParameters RSAPublicKey;
        public RSAParameters RSAPrivateKey;
        private static RSACryptoServiceProvider RSA = new(RSAKEYLENGTH);
        public RSADESEncryption()
        {
            
            //creating rsa pair keys with random data

            //CreatingRSAKeys();
        }


        public void CreatingRSAKeys()
        {
            /*
            RSAPrivateKey = RSA.ExportParameters(true);
            RSAPublicKey = RSA.ExportParameters(false);
            */


            //var primes = Enumerable.Range(minRange, int.MaxValue - 1).Where(num => num.isPrime());


            //creating p and q - 1024
            bool isCreated = false;
            while (!isCreated)
            {
                PostProcessingRNG RNG = new();
                var rsaKeysData = RNG.GetRandomData();


                int twoNumbers = 0;
                BigInteger[] pq = new BigInteger[2]; // p, q
                for(int i = 0;i<rsaKeysData.Length - RSAKEYLENGTH; i++)
                {
                    var key = rsaKeysData.Skip(i).Take(RSAKEYLENGTH / (sizeof(byte) * 8 * 2)).ToArray();

                    BigInteger bigInteger = new(key);

                    if (
                        //bigInteger.isPrime()
                        bigInteger.IsProbablyPrime()
                        )
                    {
                        pq[twoNumbers++] = bigInteger;

                        if (twoNumbers == 2) break;
                    }

                }

                BigInteger n = pq[0] * pq[1];
                BigInteger phi = (pq[0] - 1) * (pq[1] - 1);
                BigInteger e;
                List<BigInteger> exponentList = new();
                Random random = new();


                for(BigInteger i = 300; i < 1_000_000; i++)
                {
                    var gcd = ExtensionClass.Euclid(phi, i);
                    if (gcd.IsOne) exponentList.Add(i);
                }
                BigInteger d;
                (BigInteger, BigInteger) secret;
                do
                {
                    e = exponentList[random.Next() % exponentList.Count];
                    secret = ExtensionClass.Exteuclid(phi, e);

                } while (!secret.Item1.IsOne);
                d = secret.Item2;


                var inverseQ = ExtensionClass.Exteuclid(pq[0], pq[1]).Item2;
                //var DP = ExtensionClass.exteuclid(d, pq[0]).Item2;
                //var DQ = ExtensionClass.exteuclid(d, pq[1]).Item2;
                //var DP2 = ExtensionClass.exteuclid(pq[0], d);
                //var DQ2 = ExtensionClass.exteuclid(pq[1], d);


                //adding calculated values to RSA keys

                RSAParameters publicKey = new()
                {
                    Modulus = n.BigIntegerToRSAByteArray(),
                    Exponent = e.BigIntegerToRSAByteArray()
                };


                RSAParameters privateKey = new()
                {
                    Modulus = n.BigIntegerToRSAByteArray(),
                    D = d.BigIntegerToRSAByteArray(),
                    Exponent = e.BigIntegerToRSAByteArray(),
                    P = pq[0].BigIntegerToRSAByteArray(),
                    Q = pq[1].BigIntegerToRSAByteArray(),
                    DP = (d % (pq[0] - 1)).BigIntegerToRSAByteArray(),
                    DQ = (d % (pq[1] - 1)).BigIntegerToRSAByteArray(),
                    InverseQ = inverseQ.BigIntegerToRSAByteArray()
                };

                RSAPublicKey = publicKey;
                RSAPrivateKey = privateKey;

                RSA = new RSACryptoServiceProvider();
                try
                {
                    RSA.ImportParameters(RSAPrivateKey);
                    RSA.ImportParameters(RSAPublicKey);
                    isCreated = true;
                }
                catch (Exception)
                {
                    isCreated = false;
                }

            }

        }


        public bool IsSignatureVerified(string dataToVerify)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(dataToVerify);
            byte[]? signedBytes;

            //signing with private key
            signedBytes = RSAHashAndSign(bytes, RSAPrivateKey);


            return (signedBytes is not null) && VerifySign(bytes, signedBytes, RSAPublicKey);
        }

        static public bool VerifySign(byte[] bytes, byte[] signedBytes, RSAParameters RSAKey)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new();
                RSAalg.ImportParameters(RSAKey);
                return RSAalg.VerifyData(bytes, SHA256.Create(), signedBytes);
            }
            catch (Exception)
            {
                return false;
            }
            

        }

        static public byte[]? RSAHashAndSign(byte[] bytes, RSAParameters RSAKey)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new();
                RSAalg.ImportParameters(RSAKey);
                return RSAalg.SignData(bytes, SHA256.Create());
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string PublicKey()
        {
            StringWriter sw = new();
            XmlSerializer xs = new(typeof(RSAParameters));
            xs.Serialize(sw, RSAPublicKey);
            return sw.ToString();
        }

        public string PrivateKey()
        {
            StringWriter sw = new();
            XmlSerializer xs = new(typeof(RSAParameters));
            xs.Serialize(sw, RSAPrivateKey);
            return sw.ToString();
        }


        public byte[] Encrypt(string plainText)
        {

            //adding public key to rsa provider
            RSA = new RSACryptoServiceProvider(2048);
            RSA.ImportParameters(RSAPublicKey);


            //encrypt with public key
            var plainByteArray = Encoding.UTF8.GetBytes(plainText);
            var RSACypher = RSA.Encrypt(plainByteArray, false);


            //encrypt with des
            DES des = DES.Create();
            des.Padding = PaddingMode.None;
            DesIV = des.IV;
            DesKey = des.Key;

            using MemoryStream stream = new();
            using CryptoStream cs = new(stream, des.CreateEncryptor(DesKey, DesIV), CryptoStreamMode.Write);
            cs.Write(RSACypher, 0, RSACypher.Length);
            return stream.ToArray();
        }

        public string Decrypt(byte[] cypherText)
        {
            //decrypt with des parameters
            byte[] DESDecrypt;
            DES des = DES.Create();
            des.Padding = PaddingMode.None;
            using (MemoryStream stream = new())
            {
                using CryptoStream cs = new(stream, des.CreateDecryptor(DesKey!, DesIV!), CryptoStreamMode.Write);

                cs.Write(cypherText);
                DESDecrypt = stream.ToArray();
            }

            //decrypt with rsa algorithm with private key
            RSA.ImportParameters(RSAPrivateKey);

            var plainArray = RSA.Decrypt(DESDecrypt, false);
            
            return Encoding.UTF8.GetString(plainArray);
        }





        public static string GetStringFromByteArray(byte[] arr)
        {
            var temp = System.Text.Encoding.UTF8.GetString(arr);
            return temp;
        }

    }
}
