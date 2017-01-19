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

namespace MessageEncryption
{
    public partial class Primatelj : Form
    {
        Aes aes;
        byte[] getMessage;
        String receivedText;
        UdpClient client = new UdpClient(10223);

        String[] encryptedMessage;


        string[] separators = new string[] { "==" };


        public Primatelj()
        {
            InitializeComponent();
        }

        public Primatelj(String simKey,Aes aes)
        {
            InitializeComponent();
            txtKeyReceiver.Text = simKey;
            this.aes = aes;
            TextBox.CheckForIllegalCrossThreadCalls = false; 
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                aes.Key = Convert.FromBase64String(txtKeyReceiver.Text);            
                Simetrična_enkripcija simEnkripcija = new Simetrična_enkripcija(aes, "", txtReceivedMessage.Text);
                txtDecrypted.Text = simEnkripcija.Dekriptiraj();

            }
            catch
            {
                MessageBox.Show("Neispravna dekripcija");
            }
        }

        

        private void Primatelj_Load(object sender, EventArgs e)
        {          
                try
                {
                    client.BeginReceive(new AsyncCallback(receiveMessage), null);
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            
        }

        private void receiveMessage(IAsyncResult res)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10223);
            getMessage = client.EndReceive(res, ref ep);

            receivedText = UnicodeEncoding.Unicode.GetString(getMessage);
            
            showMessage(receivedText);        
            client.BeginReceive(new AsyncCallback(receiveMessage), null);
        }

        private void showMessage(String text)
        {
            txtReceivedMessage.Text = text;
        }
        
    }
}
