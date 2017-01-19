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
    public partial class Provjeri_potpis : Form
    {
        String poruka;
        Aes aes;
        RSACryptoServiceProvider rsa;
        SHA256 sha;
        string[] spliter = { "==" };

        string[] message;

        public Provjeri_potpis()
        {
            InitializeComponent();
        }
        public Provjeri_potpis(String poruka, Aes aes, RSACryptoServiceProvider rsa)
        {
            InitializeComponent();
            this.poruka = poruka;
            this.aes = aes;
            this.rsa = rsa;
            sha = SHA256.Create();
        }
        private void Provjeri_potpis_Load(object sender, EventArgs e)
        {
            textBox1.Text = poruka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = UnicodeEncoding.Unicode.GetString(rsa.Decrypt(Convert.FromBase64String(textBox1.Text),false));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            message = textBox2.Text.Split(spliter, StringSplitOptions.None);
            Simetrična_enkripcija sim = new Simetrična_enkripcija(aes, "", message[0]+"==");
            textBox3.Text = sim.Dekriptiraj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            message = textBox2.Text.Split(spliter, StringSplitOptions.None);
            String hash = Convert.ToBase64String(sha.ComputeHash(UnicodeEncoding.Unicode.GetBytes(textBox3.Text)));

            if (message[1] == hash)
            {
                MessageBox.Show("Potpis je ispravan");
            }
            else
            {
                MessageBox.Show("Potpis je neispravan");
            }

        }
    }
}
