using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR37_Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyContainerName = "TestKey";
            Encryprtor.PersistKeyInCSP(keyContainerName);

            // if you need you may export keys to xml string
            // rsa.ToXmlString(true)  - open and private key
            // rsa.ToXmlString(false) - only open key
            // or export key data to blob
            // rsa.ExportCspBlob
            // rsa.ImportCspBlob

            string text = "KyKy!!!";

            byte[] encriptedData = Encryprtor.Encrypt(text, keyContainerName);

            Console.WriteLine("Encrypted data:");
            foreach (var b in encriptedData)
            {
                Console.Write(b.ToString("x") + " ");
            }

            Console.WriteLine("\r\n\r\nDecrypted data:");

            string decryptedText = Encryprtor.Decrypt(encriptedData, keyContainerName);

            Console.WriteLine(decryptedText);

            Console.ReadLine();
        }
    }
}
