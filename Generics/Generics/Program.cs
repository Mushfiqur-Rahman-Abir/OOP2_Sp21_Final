using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int,float> s1 = new Stack<int,float>();
            s1.Push(0);
            s1.Push(12);
            s1.Push(4);
            s1.Push(5);

            s1.Pop();
            s1.Pop();
            Console.WriteLine(s1.Peek());

            Stack<string,double> s2 = new Stack<string,double>();
        }
    }
}
