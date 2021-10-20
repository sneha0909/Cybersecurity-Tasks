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

namespace Task2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string text;
        string finalstring;
        byte[] te;
        byte[] storeKey;

        private void button1_Click(object sender, EventArgs e)
        {

            string filepath = @"C:\Users\msi-pc\source\repos\Task2\Cyphertext.txt";
            string filepath2 = @"C:\Users\msi-pc\source\repos\Task2\Key.txt";
            string filepath3 = @"C:\Users\msi-pc\source\repos\Task2\Decryptedtext.txt";


            byte[] readBytes = File.ReadAllBytes(filepath);

            text = Encoding.Default.GetString(readBytes);


            te = new byte[text.Length];
            te = Encoding.Default.GetBytes(text);

            SymmetricAlgorithm sa = TripleDES.Create();


            //storeKey = File.ReadAllBytes(filepath2);
            sa.Key = File.ReadAllBytes(filepath2);

            //storeKey = sa.Key;
            //sa.Key = storeKey;


            

            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream(te);
            CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);
            byte[] plainbytes2 = new byte[te.Length];
            cs.Read(plainbytes2, 0, te.Length);
            cs.Close();
            ms.Close();
            

            finalstring = Encoding.Default.GetString(plainbytes2);
            textBox1.Text = finalstring;
            File.WriteAllText(filepath3, finalstring);

            MessageBox.Show("Congratulations!!!!Task 2 Completed");


        }
    }
}
