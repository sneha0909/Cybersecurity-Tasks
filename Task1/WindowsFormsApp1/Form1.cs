﻿using System;
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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str;
        byte[] key;
        byte[] te;
        byte[] cipherbytes;

        private void button1_Click(object sender, EventArgs e)
        {
            SymmetricAlgorithm sa = TripleDES.Create();
            sa.GenerateKey();
            key = sa.Key;
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] plainbytes = Encoding.Default.GetBytes(textBox1.Text);
            cs.Write(plainbytes, 0, plainbytes.Length);
            cs.Close();
            cipherbytes = ms.ToArray();
            ms.Close();

            str = Encoding.Default.GetString(cipherbytes);
            textBox2.Text = str;

            te = new Byte[str.Length];
            te = Encoding.Default.GetBytes(str);
            SymmetricAlgorithm sa2 = TripleDES.Create();
            sa2.Key = key;
            
            sa2.Mode = CipherMode.ECB;
            sa2.Padding = PaddingMode.PKCS7;
            MemoryStream ms2 = new MemoryStream(te);
            CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
            byte[] plainbytes2 = new Byte[te.Length];
            cs2.Read(plainbytes2, 0, te.Length);
            cs2.Close();
            ms2.Close();
            textBox3.Text = Encoding.Default.GetString(plainbytes2);
























        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
