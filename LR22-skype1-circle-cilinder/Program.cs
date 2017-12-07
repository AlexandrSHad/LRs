using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR22_skype1_circle_cilinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle with r = 7.");
            var cir = new Circle(7);
            cir.Display();

            Console.WriteLine("Cilinder with r = 7, h = 7.");
            var cil = new Cilinder(7, 7);
            cil.Display();

            Console.ReadLine();
        }
    }

    public class Circle
    {
        protected double _r;

        public Circle(int r)
        {
            _r = r;
        }

        public virtual int Area
        {
            get
            {
                return (int)(3.14 * _r * _r);
            }
        }

        public virtual void Display()
        {
            Console.WriteLine(Area);
        }
    }

    public class Cilinder : Circle
    {
        protected int _h;

        public Cilinder(int r, int h) : base (r)
        {
            _h = h;
        }

        public override int Area
        {
            get
            {
                return (int)(base.Area * 2 + 2 * 3.14 * _r * _h);
            }
        }

        public int Volume
        {
            get
            {
                return (int)(base.Area * _h);
            }
        }

        public override void Display()
        {
            Console.WriteLine("{0} {1}", Area, Volume);
        }
    }
}
