using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR27_skype6_num_to_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          0: {0}", NumToWordConverter.Convert(0));
            Console.WriteLine("        273: {0}", NumToWordConverter.Convert(273));
            Console.WriteLine("        400: {0}", NumToWordConverter.Convert(400));
            Console.WriteLine("        501: {0}", NumToWordConverter.Convert(501));
            Console.WriteLine("        660: {0}", NumToWordConverter.Convert(660));
            Console.WriteLine("        711: {0}", NumToWordConverter.Convert(711));
            Console.WriteLine("      1 000: {0}", NumToWordConverterExtended.Convert(1000));
            Console.WriteLine("      1 777: {0}", NumToWordConverterExtended.Convert(1777));
            Console.WriteLine("    465 450: {0}", NumToWordConverterExtended.Convert(465450));
            Console.WriteLine("  1 000 000: {0}", NumToWordConverterExtended.Convert(1000000));
            Console.WriteLine("  7 987 700: {0}", NumToWordConverterExtended.Convert(7987700));
            Console.WriteLine("497 250 717: {0}", NumToWordConverterExtended.Convert(497250717));

            //for (int i = 0; i<150; i++)1
            //{
            //    Console.WriteLine("{0,3}: {1}", i, NumToWordConverter.Convert(i));
            //}
        }
    }

    public static class NumToWordConverter
    {
        private static bool _needAnd;

        private static Dictionary<int, string> NumbersRepresentDict = new Dictionary<int, string>
        {
            {  1, "One" },
            {  2, "Two" },
            {  3, "Three" },
            {  4, "Four" },
            {  5, "Five" },
            {  6, "Six" },
            {  7, "Seven" },
            {  8, "Eight" },
            {  9, "Nine" },
            { 10, "Ten" },
            { 11, "Eleven" },
            { 12, "Twelve" },
            { 13, "Thirteen" },
            { 14, "Fourteen" },
            { 15, "Fifteen" },
            { 16, "Sixteen" },
            { 17, "Seventeen" },
            { 18, "Eighteen" },
            { 19, "Nineteen" },
            { 20, "Twenty" },
            { 30, "Thirty" },
            { 40, "Fourty" },
            { 50, "Fifty" },
            { 60, "Sixty" },
            { 70, "Seventy" },
            { 80, "Eighty" },
            { 90, "Ninety" }
        };

        public static string Convert(int number)
        {
            if (number == 0)
            {
                return "Zero";
            }

            string result = "";
            _needAnd = false;

            for (int power = 2; power >= 0; power--)
            {
                if (NumbersRepresentDict.ContainsKey(number))
                {
                    result = ConcateDigitRepresentation(result, NumbersRepresentDict[number]);
                    break;
                }

                int tenPower = (int)Math.Pow(10, power);

                int digit = number / tenPower;

                if (digit != 0)
                {
                    if (number < 100)
                    {
                        result = ConcateDigitRepresentation(result, NumbersRepresentDict[digit * 10]);
                    }
                    else
                    {
                        result = ConcateDigitRepresentation(result, NumbersRepresentDict[digit]);
                    }

                    if (power == 2)
                    {
                        result += " Hundred";
                        _needAnd = true;
                    }
                }

                number = number % tenPower;
            }

            return result;
        }

        private static string ConcateDigitRepresentation(string curResult, string curRepresentation)
        {
            string spaceRepresentation;

            if (_needAnd)
            {
                spaceRepresentation = " and ";
                _needAnd = false;
            }
            else
            {
                spaceRepresentation = curResult == "" ? "" : " ";
            }

            Console.WriteLine("world!");

            return String.Format($"{curResult}{spaceRepresentation}{curRepresentation}");
        }
    }

    public static class NumToWordConverterExtended
    {
        private static bool _needAnd;

        private static Dictionary<int, string> NumbersRepresentDict = new Dictionary<int, string>
        {
            {  1, "One" },
            {  2, "Two" },
            {  3, "Three" },
            {  4, "Four" },
            {  5, "Five" },
            {  6, "Six" },
            {  7, "Seven" },
            {  8, "Eight" },
            {  9, "Nine" },
            { 10, "Ten" },
            { 11, "Eleven" },
            { 12, "Twelve" },
            { 13, "Thirteen" },
            { 14, "Fourteen" },
            { 15, "Fifteen" },
            { 16, "Sixteen" },
            { 17, "Seventeen" },
            { 18, "Eighteen" },
            { 19, "Nineteen" },
            { 20, "Twenty" },
            { 30, "Thirty" },
            { 40, "Fourty" },
            { 50, "Fifty" },
            { 60, "Sixty" },
            { 70, "Seventy" },
            { 80, "Eighty" },
            { 90, "Ninety" }
        };

        private static Dictionary<int, string> PowerRepresentDict = new Dictionary<int, string>
        {
            { 3, "Thousend"},
            { 6, "Million"}
        };

        public static string Convert(int number)
        {
            if (number == 0)
            {
                return "Zero";
            }

            string result = "";
            _needAnd = false;

            for (int power = 8; power >= 0; power--)
            {
                if (NumbersRepresentDict.ContainsKey(number))
                {
                    result = ConcateDigitRepresentation(result, NumbersRepresentDict[number]);
                    break;
                }

                int tenPower = (int)Math.Pow(10, power);

                int digit = number / tenPower;

                if (digit != 0)
                {
                    if ((power + 2) % 3 == 0)
                    {
                        result = ConcateDigitRepresentation(result, NumbersRepresentDict[digit * 10]);
                    }
                    else
                    {
                        result = ConcateDigitRepresentation(result, NumbersRepresentDict[digit]);
                    }

                    if ((power + 1) % 3 == 0)
                    {
                        result += " Hundred"; // insert beafore number in some power
                        _needAnd = true;
                    }

                    if (power % 3 == 0)
                    {
                        result += " " + PowerRepresentDict[power];
                    }
                }

                number = number % tenPower;
            }

            return result;
        }

        private static string ConcateDigitRepresentation(string curResult, string curRepresentation)
        {
            string spaceRepresentation;

            if (_needAnd)
            {
                spaceRepresentation = " and ";
                _needAnd = false;
            }
            else
            {
                spaceRepresentation = curResult == "" ? "" : " ";
            }

            return String.Format($"{curResult}{spaceRepresentation}{curRepresentation}");
        }
    }
}
