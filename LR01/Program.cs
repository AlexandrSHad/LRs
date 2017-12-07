using System;

namespace LR01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. bool, int, long, double, float, char, string
            bool b = true;
            int i = 100;
            long l = 12562224;
            double d = 10.0;
            float f = 1111.11f;
            char c = 'A';
            string s = "This is a string.";

            Console.WriteLine("bool: " + b);
            Console.WriteLine("int: " + i);
            Console.WriteLine("long: " + l);
            Console.WriteLine("double: " + d);
            Console.WriteLine("float: " + f);
            Console.WriteLine("char: " + c);
            Console.WriteLine("string: " + s);

            // 2. const
            const int c_i = 1;
            const string c_s = "const";

            Console.WriteLine("const int: " + c_i);
            Console.WriteLine("const string: " + c_s);

            // 3. var
            var v_i = 100;
            var v_s = "tratata";

            Console.WriteLine("var int: " + v_i);
            Console.WriteLine("var string: " + v_s);

            // 4. convertation
            // 4.1. implicit
            byte bt = 101;
            int ibt = bt;
            Console.WriteLine("implicitly convert byte to int: " + bt);

            int it = 200002;
            long lit = it;
            Console.WriteLine("implicitly convert int to long: " + lit);

            // 4.2. explicit
            long lng = 202;
            int ilng = (int)lng;
            Console.WriteLine("explicitly convert long to int: " + ilng);

            int it2 = 55;
            byte bit2 = (byte)it2;
            Console.WriteLine("explicitly convert int to byte: " + bit2);

            // 4.3. convert
            // int -> string
            string s1 = Convert.ToString(100);

            // char -> string
            string s2 = Convert.ToString('S');

            // string -> int
            int i1 = Convert.ToInt32("1111");

            // int -> double
            double d1 = Convert.ToDouble(100);

            Console.WriteLine("Convert.ToString(100): " + s1);
            Console.WriteLine("Convert.ToString('S'): " + s2);
            Console.WriteLine("Convert.ToInt32(\"1111\"): " + i1);
            Console.WriteLine("Convert.ToDouble(100): " + d1);

            Console.ReadLine();
        }
    }
}
