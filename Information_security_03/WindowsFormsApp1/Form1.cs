using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RSAParameters privateKey;
        RSAParameters publicKey;
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();

            //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(); 

            privateKey = rsa.ExportParameters(true);
            publicKey = rsa.ExportParameters(false);
        }

        private void Encryptbutton_Click(object sender, EventArgs e)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            byte[] input = Convert.FromBase64String(textBox1.Text);
            byte[] output;

            output = RSAEncryption(input, publicKey, false);

            MessageBox.Show(Convert.ToBase64String(output), "Encryption");
            string path = @"E:\Visual_Studio_Projects\Information_systems_02\result.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Convert.ToBase64String(output));
                }
            }        
            
            GetPublicKeyString();

            try
            {
                using (StreamReader sr = new StreamReader(@"E:\Visual_Studio_Projects\Information_systems_02\result.txt"))
                {
                    textBox2.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Decryptbutton_Click(object sender, EventArgs e)
        {
          

            UnicodeEncoding byteConverter = new UnicodeEncoding();
            byte[] input = Convert.FromBase64String(textBox2.Text);
            byte[] output;

            output = RSADecryption(input, privateKey, false);

            MessageBox.Show(Convert.ToBase64String(output), "Decryption");
        }

        static public byte[] RSAEncryption(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }

        static public byte[] RSADecryption(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(RSAKeyInfo);
            return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
        }

        public void GetPublicKeyString()
        {
            //var rsa = new RSACryptoServiceProvider(2048);
            var rsaKeyPair = DotNetUtilities.GetRsaKeyPair(rsa);
            var writer = new StringWriter();
            var pemWriter = new PemWriter(writer);
            pemWriter.WriteObject(rsaKeyPair.Public);
            pemWriter.WriteObject(rsaKeyPair.Private);
            string path = @"E:\Visual_Studio_Projects\Information_systems_02\key.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(writer);
                }
            }
            /*var lines = System.IO.File.ReadAllLines(@"E:\Visual_Studio_Projects\Information_systems_02\key.txt");
            System.IO.File.WriteAllLines(@"E:\Visual_Studio_Projects\Information_systems_02\key.txt", lines.Skip(1).ToArray());
            lines = System.IO.File.ReadAllLines(@"E:\Visual_Studio_Projects\Information_systems_02\key.txt");
            System.IO.File.WriteAllLines(@"E:\Visual_Studio_Projects\Information_systems_02\key.txt", lines.Take(lines.Length - 2).ToArray());*/
        }
    }
}

