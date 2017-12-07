using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR21_lms_4._2_delegate_event_lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.WriteLine(@"Please,  type the number:

                        Generics      Class Derived : Base<Derived>
                        1.  Static base constructor
                        2.  Protected base constructor (StackOverflow !)
                        3.  Static base constructor, public field
                        4.  Protected base constructor, static field

                        Generics      Delegats & List
                        5.  Generic delegates, extension methods, List  
                
                        ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                Swap<Derived>();
                                break;
                            case 2:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                Swap<Derived_publ>();
                                break;
                            case 3:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                Swap<Derived_public_field>();
                                break;
                            case 4:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                var d = new Derived_static_field();
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.WriteLine("Create currying ...");

                                var source = new List<double> { 1.0, 2.4, 34.9, 9.02, 7.0 };
                                var result = new List<double>();

                                Func<double, double, double> f = (x, y) => x - y;

                                var fBnd = f.Bnd()(2.0);

                                Console.WriteLine("Source list.");
                                foreach (var v in source)
                                {
                                    Console.Write("{0} ; ", v);
                                    result.Add(fBnd(v));
                                }

                                Console.WriteLine("");
                                Console.WriteLine("Result list.");
                                foreach (var v in result)
                                {
                                    Console.Write("{0} ; ", v);
                                }
                                Console.WriteLine();

                                break;

                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Press Spacebar to exit; press any key to continue");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Swap<T>() where T : new()
        {
            T puzzle = new T();
            Console.WriteLine("");
        }
    }

    public static class Curry_list
    {
        public static Func<TArg2, Func<TArg1, TResult>> Bnd<TArg1, TArg2, TResult>(this Func<TArg1, TArg2, TResult> f)
        {
            return (y) => ((x) => f(x, y));
        }
    }

    public class Base_publ<T> where T : new()
    {
        public Base_publ()
        {
            var t = new T();
            Console.WriteLine("Static constructor in Base_publ<T>. new T() = {0}", t);
        }

        private T _instance;
        public T Instance
        {
            get
            {
                Console.WriteLine("Public field.");
                _instance = new T();
                return _instance;
            }
        }
    }

    public sealed class Derived_publ : Base_publ<Derived_publ>
    {
        public Derived_publ()
        {
            Console.WriteLine("Constructor in Derived_publ.");
        }
    }

    public class Base_static_field<T> where T : new()
    {
        protected Base_static_field()
        {
            Console.WriteLine("Protected constructor in Base_static_field<T>.");
        }

        private static T _instance;
        public static T Instance
        {
            get
            {
                Console.WriteLine("Public field.");
                _instance = new T();
                return _instance;
            }
        }
    }

    public sealed class Derived_static_field : Base_static_field<Derived_public_field>
    {
        public Derived_static_field()
        {
            Console.WriteLine("Constructor in Derived_static_field.");
        }
    }

    public class Base_public_field<T> where T : new()
    {
        static Base_public_field()
        {
            var t = new T();
            Console.WriteLine("Static constructor in Base_public_field<T>. new T() = {0}", t);
        }

        private T _instance;
        public T Instance
        {
            get
            {
                Console.WriteLine("Public field.");
                _instance = new T();
                return _instance;
            }
        }
    }

    public sealed class Derived_public_field : Base_public_field<Derived_public_field>
    {
        public Derived_public_field()
        {
            Console.WriteLine("Constructor in Derived_public_field.");
        }
    }

    public class Base<T> where T : new()
    {
        static Base()
        {
            var t = new T();
            Console.WriteLine("Static constructor in Base<T>. new T() = {0}", t);
        }
    }

    public sealed class Derived : Base<Derived>
    {
        public Derived()
        {
            Console.WriteLine("Constructor in Derived.");
        }
    }
}
