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

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RSAParameters rsaParams;
        
        string stringP;
        string stringQ;
        string stringE;
        string stringD;
        string cipherstring;
        string plainstring;
        byte[] FirstParameterP;
        byte[] SecondParameterQ;
        byte[] ThirdParameterE;
        byte[] FourthParameterD;
        byte[] cipherbytes;
        byte[] te;
        byte[] plainbytes;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create RSA Algorithm
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //get public and private parameters

            rsaParams = rsa.ExportParameters(true);

            stringP = Encoding.Default.GetString(rsaParams.P);


            FirstParameterP = new Byte[stringP.Length];
            FirstParameterP = Encoding.Default.GetBytes(stringP);


            textBox1.Text = BitConverter.ToString(FirstParameterP).Replace("-", " ");

            stringQ = Encoding.Default.GetString(rsaParams.Q);


            SecondParameterQ = new Byte[stringQ.Length];
            SecondParameterQ = Encoding.Default.GetBytes(stringQ);


            textBox2.Text = BitConverter.ToString(SecondParameterQ).Replace("-", " ");

            stringE = Encoding.Default.GetString(rsaParams.Exponent);


            ThirdParameterE = new Byte[stringE.Length];
            ThirdParameterE = Encoding.Default.GetBytes(stringE);


            textBox3.Text = BitConverter.ToString(ThirdParameterE).Replace("-", " ");

            stringD = Encoding.Default.GetString(rsaParams.D);


            FourthParameterD = new Byte[stringD.Length];
            FourthParameterD = Encoding.Default.GetBytes(stringD);


            textBox4.Text = BitConverter.ToString(FourthParameterD).Replace("-", " ");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create RSA algorithm

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //import parameters rsaParams to RSA algorithm (step 1)
            rsa.ImportParameters(rsaParams);

            //read text for encrypt
            byte[] plainbytes = Encoding.Default.GetBytes(textBox5.Text);

            //call Encrypt function (step2)

            cipherbytes = rsa.Encrypt(plainbytes, false);

            

            //Show results (step3)

            cipherstring = Encoding.Default.GetString(cipherbytes);

           // cipherstring =  Convert.ToBase64String(cipherbytes);


            textBox6.Text = cipherstring;


            te = new Byte[cipherstring.Length];
            te = Encoding.Default.GetBytes(cipherstring);


            textBox7.Text = BitConverter.ToString(te).Replace("-", " ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create RSA algorithm
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //import parameters rsaParams to RSA algorithm (step 1)

            rsa.ImportParameters(rsaParams);

            //call Decrypt function (step 2)

            plainbytes = rsa.Decrypt(cipherbytes, false);

            //show results(step 3)

            plainstring = Encoding.Default.GetString(plainbytes);
            textBox8.Text = plainstring;

            Form3 form2 = new Form3();
            form2.Show();



        }
    }
}
