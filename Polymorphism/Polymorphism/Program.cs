using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Abir", "19-40008-1", "31-12-1999", 3.57f, 79);
            s1.ShowInfo();

            Person p = new Student("Sabir", "316", "31-12-2006", 4.09f, 14);
            p.ShowInfo();
        }
    }
}
