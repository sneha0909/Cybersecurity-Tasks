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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
       
        byte[] cipherbytes;
        byte[] storeKey;


        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\msi-pc\source\repos\Task2\Cyphertext.txt";
            string filepath2 = @"C:\Users\msi-pc\source\repos\Task2\Key.txt";
            SymmetricAlgorithm sa = TripleDES.Create();

            storeKey = File.ReadAllBytes(filepath2);
            sa.Key = storeKey;


            
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] plainbytes = Encoding.Default.GetBytes(textBox1.Text);
            cs.Write(plainbytes, 0, plainbytes.Length);
            cs.Close();
            cipherbytes = ms.ToArray();
            ms.Close();

            File.WriteAllBytes(filepath, cipherbytes);
            Form3 form3 = new Form3();
            form3.Show();





        }
    }
}
