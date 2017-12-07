using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR03_vovk_koza_kapusta
{
    class Program
    {
        static void Main(string[] args)
        {
            //koza->
            //<-
            //kapusta->
            //koza<-
            //vovk->
            //<-
            //koza->

            //koza->
            //<-
            //vovk->
            //koza<-
            //kapusta->
            //<-
            //koza->

            Console.WriteLine("Koza - koz, kapusta - kap, vovk - vov, Enter - holosta yizdka.");

            Console.WriteLine("Kogo vezemo tudy?: ");
            string passenger = Console.ReadLine();

            if (passenger == "koz")
            {
                Console.WriteLine("Kogo vezemo nazad?: ");
                passenger = Console.ReadLine();

                if (passenger == "")
                {
                    Console.WriteLine("Kogo vezemo tudy?: ");
                    passenger = Console.ReadLine();

                    if (passenger == "kap")
                    {
                        Console.WriteLine("Kogo vezemo nzad?: ");
                        passenger = Console.ReadLine();

                        if (passenger == "koz")
                        {
                            Console.WriteLine("Kogo vezemo tudy?: ");
                            passenger = Console.ReadLine();

                            if (passenger == "vov")
                            {
                                Console.WriteLine("Kogo vezemo nazad?: ");
                                passenger = Console.ReadLine();

                                if (passenger == "")
                                {
                                    Console.WriteLine("Kogo vezemo tudy?: ");
                                    passenger = Console.ReadLine();

                                    if (passenger == "koz")
                                    {
                                        Console.WriteLine("Ura! Ty pereviz vsih!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vse propalo.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Vse propalo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Vse propalo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vse propalo.");
                        }
                    }
                    else if (passenger == "vov")
                    {
                        Console.WriteLine("Kogo vezemo nazad?: ");
                        passenger = Console.ReadLine();

                        if (passenger == "koz")
                        {
                            Console.WriteLine("Kogo vezemo tudy?: ");
                            passenger = Console.ReadLine();

                            if (passenger == "kap")
                            {
                                Console.WriteLine("Kogo vezemo nazad?: ");
                                passenger = Console.ReadLine();

                                if (passenger == "")
                                {
                                    Console.WriteLine("Kogo vezemo tudy?: ");
                                    passenger = Console.ReadLine();

                                    if (passenger == "koz")
                                    {
                                        Console.WriteLine("Ura! Ty pereviz vsih!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vse propalo.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Vse propalo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Vse propalo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vse propalo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vse propalo.");
                    }
                }
                else
                {
                    Console.WriteLine("Vse propalo.");
                }
            }
            else
            {
                Console.WriteLine("Vse propalo.");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
