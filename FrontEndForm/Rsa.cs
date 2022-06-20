using RsaEncryptionTRNG;
using System.Security.Cryptography;
using System.Text;
using System.Numerics;


namespace FrontEndForm
{
    public partial class RSASignature : Form
    {
        RSACryptoServiceProvider? rsa;
        RSAParameters RSAPublicKey;
        RSAParameters RSAPrivateKey;
        public RSASignature()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HashButton_Click(object sender, EventArgs e)
        {
            string signature = this.signatureText.Text;
            string signatureCheck = this.signatureCheckText.Text;
            string signatureHash = Encoding.Unicode.GetString(SHA256.Create().ComputeHash(Encoding.Unicode.GetBytes(signature)));
            string signatureCheckHash = Encoding.Unicode.GetString(SHA256.Create().ComputeHash(Encoding.Unicode.GetBytes(signatureCheck)));

            this.signatureHashText.Text = signatureHash;
            this.signatureCheckHashText.Text= signatureCheckHash;


        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            RSADESEncryption encryption = new();
            encryption.CreatingRSAKeys();
            RSAParameters publicKey = encryption.RSAPublicKey;
            RSAParameters privateKey = encryption.RSAPrivateKey;

            this.public_e.Text = ConvertBigIntegerToText(publicKey.Exponent);
            this.public_n.Text = ConvertBigIntegerToText(publicKey.Modulus);

            this.private_e.Text = ConvertBigIntegerToText(privateKey.Exponent);
            this.private_n.Text = ConvertBigIntegerToText(privateKey.Modulus);
            this.private_d.Text = ConvertBigIntegerToText(privateKey.D);
            this.private_dp.Text = ConvertBigIntegerToText(privateKey.DP);
            this.private_dq.Text = ConvertBigIntegerToText(privateKey.DQ);
            this.private_inverse_q.Text = ConvertBigIntegerToText(privateKey.InverseQ);
            this.private_p.Text = ConvertBigIntegerToText(privateKey.P);
            this.private_q.Text = ConvertBigIntegerToText(privateKey.Q);



        }



        private void VerifySignatureButton_Click(object sender, EventArgs e)
        {

            //asserting key properties values
            List<TextBox> rsaparameters=new()
            {
                this.public_e, this.public_n,
                this.private_e, this.private_n,
                this.private_p, this.private_q,
                this.private_dp, this.private_dq,
                this.private_inverse_q, this.private_d
            };
            BigInteger Outter = 0;
            if (rsaparameters
                .Select(x => x.Text)
                .Any(x => x == null || x == String.Empty || x == "" || !BigInteger.TryParse(x, out Outter))
            )
            {
                this.verifySignatureResultLabel.Text = "RSA Keys Parameters not valid or empty";
                return;
            }


            //creating key instances from textbox numbers
            RSAPublicKey.Modulus = ConvertTextToByteArray(this.public_n.Text);
            RSAPublicKey.Exponent = ConvertTextToByteArray(this.public_e.Text);

            RSAPrivateKey.Modulus = ConvertTextToByteArray(this.private_n.Text);
            RSAPrivateKey.Exponent = ConvertTextToByteArray(this.private_e.Text);
            RSAPrivateKey.P = ConvertTextToByteArray(this.private_p.Text);
            RSAPrivateKey.Q = ConvertTextToByteArray(this.private_q.Text);
            RSAPrivateKey.InverseQ = ConvertTextToByteArray(this.private_inverse_q.Text);
            RSAPrivateKey.DQ = ConvertTextToByteArray(this.private_dq.Text);
            RSAPrivateKey.DP = ConvertTextToByteArray(this.private_dp.Text);
            RSAPrivateKey.D = ConvertTextToByteArray(this.private_d.Text);

            try
            {
                rsa = new();
                rsa.ImportParameters(RSAPublicKey);
                rsa.ImportParameters(RSAPrivateKey);
            }
            catch (Exception)
            {
                this.verifySignatureResultLabel.Text = "private key violated";
                return;
            }

            

            string hash = this.signatureHashText.Text, hashCheck = this.signatureCheckHashText.Text;
            if(String.IsNullOrEmpty(hash) || String.IsNullOrEmpty(hashCheck))
            {
                this.verifySignatureResultLabel.Text = "hashed values are null or empty";
                return;
            }
            //sign signature
            rsa = new RSACryptoServiceProvider(2048);

            rsa.ImportParameters(RSAPrivateKey);
            var signature = RSADESEncryption.RSAHashAndSign(Encoding.UTF8.GetBytes(hash), RSAPrivateKey);
            var verifiedFlag = RSADESEncryption.VerifySign(Encoding.UTF8.GetBytes(hashCheck), signature, RSAPublicKey);



            this.verifySignatureResultLabel.Text = (verifiedFlag) ? "signature verified" : "signature not valid";


        }


        static string ConvertBigIntegerToText(byte[]? keyParameter)
        {
            if (keyParameter == null) return "null";

            var temp = new BigInteger(keyParameter);

            return temp.ToString();
        }

        static byte[]? ConvertTextToByteArray(string text)
        {
            if(BigInteger.TryParse(text, out var result))
            {
                return result.ToByteArray();
            }
            return null;
        }



    }
}