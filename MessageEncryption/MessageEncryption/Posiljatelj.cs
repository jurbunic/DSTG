using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace MessageEncryption
{
    public partial class Posiljatelj : Form
    {
        static int destinationPort = 10223;
        Aes aes;

        UdpClient udpClient;

        String enkripcija;

        Simetrična_enkripcija simetricnaEnkripcija;
        

        public Posiljatelj()
        {
            InitializeComponent();
        }

        public Posiljatelj(String simKey, Aes aes)
        {
            InitializeComponent();
            txtKeySender.Text = simKey;
            this.aes = aes;
            udpClient = new UdpClient(10222);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            aes.Key = Convert.FromBase64String(txtKeySender.Text);  
            simetricnaEnkripcija = new Simetrična_enkripcija(aes, txtMessage.Text, "");
            enkripcija = simetricnaEnkripcija.Enkriptiraj();
            txtEncryptedMessage.Text = enkripcija;
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), destinationPort);
            udpClient.Connect(ep);
            byte[] message = UnicodeEncoding.Unicode.GetBytes(txtEncryptedMessage.Text);
            udpClient.Send(message, message.Length);

        }

        
        
    }
}
