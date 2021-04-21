using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {

        public delegate void arithmatic(int a, int b);

        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition: " +(a+b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        static void Main(string[] args)
        {
            arithmatic calc = Add;
            calc(12, 14);
            calc = Sub;
            calc(13, 1);
            Person p = new Person();
            calc = p.AddtoCgpa;
            calc(90, 80);

            arithmatic calc2 = Add;
            calc2 += Sub;
            calc2 += p.AddtoCgpa;
            calc2(78, 70);

            calc2 -= p.AddtoCgpa;
            calc2(78, 70);
        }
    }
}
