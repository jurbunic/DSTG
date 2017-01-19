using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncryption
{
    class Simetrična_enkripcija
    {
        Aes aes;
        String cistiTeks;
        String kriptiraniTekst;
        public Simetrična_enkripcija(Aes aes, String plainTeks, String cipherText)
        {
            this.aes = aes;
            this.cistiTeks = plainTeks;
            this.kriptiraniTekst = cipherText;
        }

        public string Enkriptiraj()
        {
            if (this.cistiTeks == null || this.aes == null)
            {
                return null;
            }
            byte[] enkriptirano;

            ICryptoTransform encryptor = this.aes.CreateEncryptor(this.aes.Key, this.aes.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(cistiTeks);
                    }
                    enkriptirano = msEncrypt.ToArray();
                }
            }
            this.kriptiraniTekst = Convert.ToBase64String(enkriptirano);
            return this.kriptiraniTekst;
        }
        public string Dekriptiraj()
        {
            string dekriptiraniTekst = "";
            if (this.kriptiraniTekst == null || this.aes == null)
            {
                return null;
            }
            ICryptoTransform decryptor = this.aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(this.kriptiraniTekst)))
            {
                using (CryptoStream csDecryptor = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecryptor = new StreamReader(csDecryptor))
                    {
                        dekriptiraniTekst = srDecryptor.ReadToEnd();
                    }
                }
            }
            return dekriptiraniTekst;

        }
    }
}

