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
    public partial class Form1 : Form
    {
        Aes aes;
       
        public Form1()
        {
            InitializeComponent();
            aes = Aes.Create();
        }

        private void btnSender_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtMainKey.Text == ""))
                {
                    Posiljatelj posiljatelj = new Posiljatelj(txtMainKey.Text, aes);
                    posiljatelj.Show();
                }
                else
                {
                    MessageBox.Show("Ključ nije kreiran!");
                }
            }
            catch
            {
                MessageBox.Show("Portovi su zauzeti");
            }
            


            
            
        }

        private void btnReceiver_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtMainKey.Text == ""))
                {
                    Primatelj primatelj = new Primatelj(txtMainKey.Text, aes);
                    primatelj.Show();
                }
                else
                {
                    MessageBox.Show("Ključ nije kreiran!");
                }
            }
            catch
            {
                MessageBox.Show("Portovi su zauzeti");
            }
            

        }

        private void btnNewKey_Click(object sender, EventArgs e)
        {
            aes.GenerateIV();
            aes.GenerateKey();
            txtMainKey.Text = Convert.ToBase64String(aes.Key);
        }

        private void btnPotpis_Click(object sender, EventArgs e)
        {
            Potpis potpis = new Potpis();
            potpis.Show();
        }
    }
}
