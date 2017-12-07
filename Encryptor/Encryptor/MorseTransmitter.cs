using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Encryptor
{
    public static class MorseTransmitter
    {
        // if _dotDuration is private readonly I can't use him in expression
        const int _dotDuration = 200;
        const int _dashDuration = 700;
        const int _spaceLettersDuration = 600;
        const int _spaceWordsDuration = 1000;

        // dot = 0, dash = 1
        static byte[][] _morseCipher = new byte[][]
        {
            new byte[] { 0, 1 },        // a
            new byte[] { 1, 0, 0, 0 },  // b
            new byte[] { 1, 0, 1, 0 },  // c
            new byte[] { 1, 0, 0 },     // d
            new byte[] { 0 },           // e
            new byte[] { 0, 0, 1, 0 },  // f
            new byte[] { 1, 1, 0 },     // g
            new byte[] { 0, 0, 0, 0 },  // h
            new byte[] { 0, 0 },        // i
            new byte[] { 0, 1, 1, 1 },  // j
            new byte[] { 1, 0, 1 },     // k
            new byte[] { 0, 1, 0, 0 },  // l
            new byte[] { 1, 1 },        // m
            new byte[] { 1, 0 },        // n
            new byte[] { 1, 1, 1 },     // o
            new byte[] { 0, 1, 1, 0 },  // p
            new byte[] { 1, 1, 0, 1 },  // q
            new byte[] { 0, 1, 0 },     // r
            new byte[] { 0, 0, 0 },     // s
            new byte[] { 1 },           // t
            new byte[] { 0, 0, 1 },     // u
            new byte[] { 0, 0, 0, 1 },  // v
            new byte[] { 0, 1, 1 },     // w
            new byte[] { 1, 0, 0, 1 },  // x
            new byte[] { 1, 0, 1, 1 },  // y
            new byte[] { 1, 1, 0, 0 }   // z
        };

        public static void Transmit(string text)
        {
            Console.WriteLine();

            text.ToLower();

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(_spaceWordsDuration);
                    continue;
                }

                Console.Write($"({c}) ");

                byte[] mc = GetMorseCipher(c);

                for (int i = 0; i < mc.Length; i++)
                {
                    if (mc[i] == 0)
                    {
                        Console.Write(". ");
                        Console.Beep(1000, _dotDuration);
                    }
                    else if ((mc[i] == 1))
                    {
                        Console.Write("- ");
                        Console.Beep(1000, _dashDuration);
                    }
                }

                Thread.Sleep(_spaceLettersDuration);
                Console.Write("  ");
            }

            Console.WriteLine();
        }

        private static byte[] GetMorseCipher(char c)
        {
            if (c == '.')
            {
                return new byte[] { 0, 0, 0, 0, 0, 0 };
            }
            else if (c == ',')
            {
                return new byte[] { 0, 1, 0, 1, 0, 1 };
            }
            else
            {
                // 97 in unicode table represents 'a' symbol
                return _morseCipher[c - 97];
            }
        }
    }
}
