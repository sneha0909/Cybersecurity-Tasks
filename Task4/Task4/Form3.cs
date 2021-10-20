using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Task4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string keyXML;
        string cipherstring;
        string plainstring;
        byte[] cipherbytes;
        byte[] te;
        private void button1_Click(object sender, EventArgs e)
        {
            //create RSA algorithm 
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //get public and private parameters
            string privateAndPublicKey = rsa.ToXmlString(true);

            //save keyXML to PrivateAndPublicKey.xml

            string filepath1 = @"C:\Users\msi-pc\source\repos\Task4\PrivateAndPublicKey.xml";

            File.WriteAllText(filepath1, privateAndPublicKey);

            //get public parameters

            string publicKey = rsa.ToXmlString(false);

            //save keyXML to publicKey.xml

            string filepath2 = @"C:\Users\msi-pc\source\repos\Task4\publicKey.xml";

            File.WriteAllText(filepath2, publicKey);

            //show public and private parameters

            textBox1.Text = privateAndPublicKey + publicKey;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create RSA algorithm

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //read key from PrivateandPublicKey.xml to keyXML variable string type

            string filepath1 = @"C:\Users\msi-pc\source\repos\Task4\PrivateAndPublicKey.xml";

            keyXML = File.ReadAllText(filepath1);

            //import parameters to RSA algorithm
            rsa.FromXmlString(keyXML);

           

            //read text for encrypt
            byte[] plainbytes = Encoding.Default.GetBytes(textBox2.Text);

            //call Encrypt function (step2)

            cipherbytes = rsa.Encrypt(plainbytes, false);



            //Show results (step3)

            cipherstring = Encoding.Default.GetString(cipherbytes);
            textBox3.Text = cipherstring;


            te = new Byte[cipherstring.Length];
            te = Encoding.Default.GetBytes(cipherstring);


            textBox4.Text = BitConverter.ToString(te).Replace("-", " ");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create RSA algorithm

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //read key from PrivateandPublicKey.xml to keyXML variable string type

            string filepath1 = @"C:\Users\msi-pc\source\repos\Task4\PrivateAndPublicKey.xml";

            keyXML = File.ReadAllText(filepath1);

            //import parameters to RSA algorithm
            rsa.FromXmlString(keyXML);

            //call Decrypt function (step 2)

             byte[] plainbytes = rsa.Decrypt(cipherbytes, false);

            //show text

            plainstring = Encoding.Default.GetString(plainbytes);
            textBox5.Text = plainstring;



        }
    }
}
