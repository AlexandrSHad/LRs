using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello, world. it is encryptor.";

            var ce = new CeasarEncryptor(text, 3);
            ce.Encrypt();
            ce.Transmit();

            Console.WriteLine();

            var ve = new VigenereEncryptor(text, "tarabaram");
            ve.Encrypt();
            ve.Transmit();

            Console.ReadLine();
        }
    }
}
