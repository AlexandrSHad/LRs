using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Encryptor
{
    public class CeasarEncryptor : IEncryptor
    {
        public CeasarEncryptor(string sourceText)
        {
            SourceText = sourceText;
        }

        public CeasarEncryptor(string sourceText, int shift)
        {
            SourceText = sourceText;
            Shift = shift;
        }

        public virtual void Encrypt()
        {
            Console.WriteLine("Ceasar encryptor.");
            Console.WriteLine($"Source text:    {SourceText}");
            Console.WriteLine($"Shift:          {Shift}");

            EncryptedText = "";

            foreach (char c in SourceText)
            {
                if (c == '.' || c == ',' || c == ' ')
                {
                    EncryptedText += c;
                }
                else
                {
                    int symbolCode = 97 + (((int)c - 97 + Shift) % 26);
                    EncryptedText += (char)symbolCode;
                }
            }

            Console.WriteLine($"Encrypted text: {EncryptedText}");
        }

        public void Transmit()
        {
            MorseTransmitter.Transmit(EncryptedText);
        }

        public string SourceText { get; set; }
        public int Shift { get; set; }
        public string EncryptedText { get; set; }
    }
}
