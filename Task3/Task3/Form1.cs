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

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] key;
        byte[] iv;
        byte[] cipherbytes;
        byte[] te;
       
        
        
        byte[] me;
        string str;
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) //DES Method
            {
                if (radioButton2.Checked) //ECB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.PKCS7;

                        
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }

                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton9.Checked) //None Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.None;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton3.Checked) //CBC Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key  ;
                        iv  = sa.IV;


                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }

                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    
                }
                if (radioButton4.Checked) //CFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv  =  sa.IV;


                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = DES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton5.Checked) //OFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = DES.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.OFB;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch(Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
                if (radioButton6.Checked) //CTS Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = DES.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.CTS;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch (Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
            }

            if (radioButton10.Checked) //TripleDES Method
            {
                if (radioButton2.Checked) //ECB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    { 
                    SymmetricAlgorithm sa = TripleDES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key= sa.Key;

                    sa.Mode = CipherMode.ECB;
                    sa.Padding = PaddingMode.PKCS7;
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                    byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                    cs.Write(plainbytes, 0, plainbytes.Length);
                    cs.Close();
                    cipherbytes = ms.ToArray();
                    ms.Close();

                    str = Encoding.Default.GetString(cipherbytes);
                    textBox4.Text = str;

                    te = new Byte[str.Length];
                    te = Encoding.Default.GetBytes(str);


                    textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }

                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = TripleDES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton3.Checked ) //CBC Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = TripleDES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;


                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = TripleDES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton4.Checked ) //CFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = TripleDES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = TripleDES.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton5.Checked ) //OFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = TripleDES.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.OFB;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch (Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
                if (radioButton6.Checked ) //CTS Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = TripleDES.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.CTS;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch (Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
            }
            if (radioButton11.Checked) //Rijndael Method
            {
                if (radioButton2.Checked) //ECB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = Rijndael.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = Rijndael.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton3.Checked) //CBC Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = Rijndael.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key= sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }

                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = Rijndael.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton4.Checked) //CFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = Rijndael.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }

                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = Rijndael.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton5.Checked) //OFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = Rijndael.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.OFB;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch (Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
                if (radioButton6.Checked) //CTS Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = Rijndael.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.CTS;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch (Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
            }

            if (radioButton12.Checked) //RC2 Method
            {
                if (radioButton2.Checked) //ECB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        
                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton3.Checked) //CBC Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton4.Checked) //CFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }

                    if (radioButton8.Checked) //Zeros Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.CFB;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton4.Checked) //OFB Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        SymmetricAlgorithm sa = RC2.Create();

                        key = Encoding.Default.GetBytes(textBox1.Text);

                        key = sa.Key;
                        iv = sa.IV;

                        sa.Mode = CipherMode.OFB;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream();
                        CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                        byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                        cs.Write(plainbytes, 0, plainbytes.Length);
                        cs.Close();
                        cipherbytes = ms.ToArray();
                        ms.Close();

                        str = Encoding.Default.GetString(cipherbytes);
                        textBox4.Text = str;

                        te = new Byte[str.Length];
                        te = Encoding.Default.GetBytes(str);


                        textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                    }
                }
                if (radioButton6.Checked) //CTS Mode
                {
                    if (radioButton7.Checked) //PKCS7 Mode
                    {
                        try
                        {
                            SymmetricAlgorithm sa = RC2.Create();

                            key = Encoding.Default.GetBytes(textBox1.Text);

                            key = sa.Key;
                            iv = sa.IV;

                            sa.Mode = CipherMode.CTS;
                            sa.Padding = PaddingMode.PKCS7;
                            MemoryStream ms = new MemoryStream();
                            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);
                            byte[] plainbytes = Encoding.Default.GetBytes(textBox3.Text);
                            cs.Write(plainbytes, 0, plainbytes.Length);
                            cs.Close();
                            cipherbytes = ms.ToArray();
                            ms.Close();

                            str = Encoding.Default.GetString(cipherbytes);
                            textBox4.Text = str;

                            te = new Byte[str.Length];
                            te = Encoding.Default.GetBytes(str);


                            textBox5.Text = BitConverter.ToString(te).Replace("-", "");
                        }
                        catch (Exception x)
                        {

                            MessageBox.Show(x.ToString());
                        }
                    }
                }
            }

        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) //DES Method Key
            {
                SymmetricAlgorithm sa = DES.Create();
                sa.GenerateKey();
                key = sa.Key;
                string KeyString = BitConverter.ToString(key);
                textBox1.Text = KeyString;


            }
            if (radioButton10.Checked) //TripleDES Method Key
            {
                SymmetricAlgorithm sa = TripleDES.Create();
                sa.GenerateKey();
                key = sa.Key;
                string KeyString = BitConverter.ToString(key);
                textBox1.Text = KeyString;
                
               
            }
            if (radioButton11.Checked) //Rijndael Method Key
            {
                SymmetricAlgorithm sa = Rijndael.Create();
                sa.GenerateKey();
                key = sa.Key;
                string KeyString = BitConverter.ToString(key);
                textBox1.Text = KeyString;


            }
            if (radioButton12.Checked) //RC2 Method Key
            {
                SymmetricAlgorithm sa = RC2.Create();
                sa.GenerateKey();
                key = sa.Key;
                string KeyString = BitConverter.ToString(key);
                textBox1.Text = KeyString;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)  //DES Method
            {
                SymmetricAlgorithm sa = TripleDES.Create();

                sa.GenerateIV();

                iv = sa.IV;
                string IVString = BitConverter.ToString(iv);
                textBox2.Text = IVString;
            }
            if (radioButton10.Checked)  //TripleDES Method
            {
                SymmetricAlgorithm sa = TripleDES.Create();

                sa.GenerateIV();
                iv = sa.IV;

                string IVString = BitConverter.ToString(iv);
                textBox2.Text = IVString;
            }
            if (radioButton11.Checked)  //Rijndael Method
            {
                SymmetricAlgorithm sa = Rijndael.Create();

                sa.GenerateIV();
                iv = sa.IV;

                string IVString = BitConverter.ToString(iv);
                textBox2.Text = IVString;
            }
            if (radioButton12.Checked)  //Rijndael Method
            {
                SymmetricAlgorithm sa = RC2.Create();

                sa.GenerateIV();
                iv = sa.IV;

                string IVString = BitConverter.ToString(iv);
                textBox2.Text = IVString;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) //DES Method
            {
                if (radioButton2.Checked == true) //ECB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa = DES.Create();

                        sa.Key = key;
                        sa.IV = iv;                       //Using the same Key for decryption.

                        sa.Mode = CipherMode.ECB;
                        sa.Padding = PaddingMode.PKCS7;

                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);


                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = DES.Create();


                        sa2.Key = key;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton9.Checked == true) //None Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = DES.Create();


                        sa2.Key = key;
                        sa2.IV = iv;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.None;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton3.Checked == true) //CBC Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = DES.Create();

                        sa2.Key = key;  //Using the same Key for decryption.
                        sa2.IV = iv;
                        
                        sa2.Mode = CipherMode.CBC;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }

                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = DES.Create();


                        sa2.Key = key;
                        sa2.IV = iv;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.CBC;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton4.Checked == true) //CFB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = DES.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = DES.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                
            }
            if (radioButton10.Checked) //TripleDES Method
            {
                if (radioButton2.Checked == true) //ECB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {
            
                        me = Encoding.Default.GetBytes(textBox4.Text);
                     
                        SymmetricAlgorithm sa2 = TripleDES.Create();


                        sa2.Key = key;
                        sa2.IV = iv;
                                              //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = TripleDES.Create();


                        sa2.Key = key;
                        sa2.IV = iv;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton3.Checked == true) //CBC Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = TripleDES.Create();

                        sa2.Key = key;  //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CBC;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }

                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = TripleDES.Create();

                        sa2.Key = key;  //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CBC;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton4.Checked == true) //CFB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = TripleDES.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = TripleDES.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
            }
            if (radioButton11.Checked) //Rijndael Method
            {
                if (radioButton2.Checked == true) //ECB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = Rijndael.Create();


                        sa2.Key = key;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = Rijndael.Create();


                        sa2.Key = key;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton3.Checked == true) //CBC Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = Rijndael.Create();

                        sa2.Key = key;  //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CBC;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }

                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = Rijndael.Create();

                        sa2.Key = key;  //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CBC;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton4.Checked == true) //CFB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = Rijndael.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = Rijndael.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
            }
            if (radioButton12.Checked) //RC2 Method
            {
                if (radioButton2.Checked == true) //ECB Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = RC2.Create();


                        sa2.Key = key;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.PKCS7;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }

                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = RC2.Create();


                        sa2.Key = key;
                        //Using the same Key for decryption.

                        sa2.Mode = CipherMode.ECB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton3.Checked == true) //CBC Mode
                {
                    if (radioButton7.Checked == true) //PKCS7 Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa = RC2.Create();

                        sa.Key = key;  //Using the same Key for decryption.
                        sa.IV = iv;
                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.PKCS7;
                        MemoryStream ms = new MemoryStream(me);
                        CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs.Read(plainbytes2, 0, me.Length);
                        cs.Close();
                        ms.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa = RC2.Create();

                        sa.Key = key;  //Using the same Key for decryption.
                        sa.IV = iv;
                        sa.Mode = CipherMode.CBC;
                        sa.Padding = PaddingMode.Zeros;
                        MemoryStream ms = new MemoryStream(me);
                        CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs.Read(plainbytes2, 0, me.Length);
                        cs.Close();
                        ms.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                if (radioButton4.Checked == true) //CFB Mode
               {
                        if (radioButton7.Checked == true) //PKCS7 Mode
                        {

                            me = Encoding.Default.GetBytes(textBox4.Text);

                            SymmetricAlgorithm sa2 = RC2.Create();

                            sa2.Key = key; //Using the same Key for decryption.
                            sa2.IV = iv;
                            sa2.Mode = CipherMode.CFB;
                            sa2.Padding = PaddingMode.PKCS7;
                            MemoryStream ms2 = new MemoryStream(me);
                            CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                            byte[] plainbytes2 = new Byte[me.Length];
                            cs2.Read(plainbytes2, 0, me.Length);
                            cs2.Close();
                            ms2.Close();
                            textBox6.Text = Encoding.Default.GetString(plainbytes2);
                        }

                    if (radioButton8.Checked == true) //Zeros Mode
                    {

                        me = Encoding.Default.GetBytes(textBox4.Text);

                        SymmetricAlgorithm sa2 = RC2.Create();

                        sa2.Key = key; //Using the same Key for decryption.
                        sa2.IV = iv;
                        sa2.Mode = CipherMode.CFB;
                        sa2.Padding = PaddingMode.Zeros;
                        MemoryStream ms2 = new MemoryStream(me);
                        CryptoStream cs2 = new CryptoStream(ms2, sa2.CreateDecryptor(), CryptoStreamMode.Read);
                        byte[] plainbytes2 = new Byte[me.Length];
                        cs2.Read(plainbytes2, 0, me.Length);
                        cs2.Close();
                        ms2.Close();
                        textBox6.Text = Encoding.Default.GetString(plainbytes2);
                    }
                }
                
            }

            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
