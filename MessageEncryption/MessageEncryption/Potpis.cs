using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageEncryption
{
    public partial class Potpis : Form
    {
        Aes aes;
        RSACryptoServiceProvider rsa;
        RSAParameters rsaParameters;
        Simetrična_enkripcija enkripcija;
        SHA256 sha = SHA256.Create();

        public Potpis()
        {
            InitializeComponent();
            aes = Aes.Create();
            aes.GenerateIV();
            aes.GenerateKey();
            rsa = new RSACryptoServiceProvider(2048);
            rsaParameters = rsa.ExportParameters(true);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enkripcija = new Simetrična_enkripcija(aes, textBox1.Text, "");
            txtDigitalSimEnc.Text = enkripcija.Enkriptiraj();
            txtDigitalKey.Text = Convert.ToBase64String(sha.ComputeHash(UnicodeEncoding.Unicode.GetBytes(textBox1.Text)));
            txtDigitalEnvelope.Text = Convert.ToBase64String(rsa.Encrypt(UnicodeEncoding.Unicode.GetBytes(txtDigitalSimEnc.Text + txtDigitalKey.Text), false));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Provjeri_potpis potpis = new Provjeri_potpis(txtDigitalEnvelope.Text,aes,rsa);
            potpis.Show();
        }
    }
}
