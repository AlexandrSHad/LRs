using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LR37_Cryptography
{
    public class Encryprtor
    {
        public static void PersistKeyInCSP(string keyContainerName)
        {
            new RSACryptoServiceProvider(new CspParameters() { KeyContainerName = keyContainerName });
        }

        public static byte[] Encrypt(string text, string keyContainerName, bool padding = false)
        {
            var byteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = byteConverter.GetBytes(text);
            byte[] encryptedData;

            using (var rsa = new RSACryptoServiceProvider(new CspParameters() { KeyContainerName = keyContainerName }))
            {
                encryptedData = rsa.Encrypt(dataToEncrypt, padding);
            }

            return encryptedData;
        }

        public static string Decrypt(byte[] dataToDecrypt, string keyContainerName, bool padding = false)
        {
            var byteConverter = new UnicodeEncoding();

            byte[] decryptedData;

            using (var rsa = new RSACryptoServiceProvider(new CspParameters() { KeyContainerName = keyContainerName }))
            {
                decryptedData = rsa.Decrypt(dataToDecrypt, padding);
            }

            return byteConverter.GetString(decryptedData);
        }
    }
}
