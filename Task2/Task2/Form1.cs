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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        byte[] storeKey;
        

        private void button1_Click(object sender, EventArgs e)
        {
            SymmetricAlgorithm sa = TripleDES.Create();
            sa.GenerateKey();
            storeKey = sa.Key;

            string filepath = @"C:\Users\msi-pc\source\repos\Task2\Key.txt";
            
            File.WriteAllBytes(filepath, storeKey);

            Form2 form2 = new Form2();
            form2.Show();





        }
    }
}
