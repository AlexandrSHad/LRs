using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public class VigenereEncryptor : CeasarEncryptor
    {
        public VigenereEncryptor(string sourceText) : base(sourceText) { }

        public VigenereEncryptor(string sourceText, string key) : base(sourceText)
        {
            Key = key;
        }

        public override void Encrypt()
        {
            Console.WriteLine("Vigenere encryptor.");
            Console.WriteLine($"Source text:    {SourceText}");
            Console.WriteLine($"Key:            {Key}");

            EncryptedText = "";

            int idxKeySymbol = 0;

            foreach (char c in SourceText)
            {
                char k = Key[idxKeySymbol % Key.Length];

                if (c == '.' || c == ',' || c == ' ')
                {
                    EncryptedText += c;
                }
                else
                {
                    int symbolCode = 97 + (((int)c - 97 + (int)k - 97) % 26);
                    EncryptedText += (char)symbolCode;
                    idxKeySymbol++;
                }
            }

            Console.WriteLine($"Encrypted text: {EncryptedText}");
        }

        public string Key { get; set; }
    }
}
