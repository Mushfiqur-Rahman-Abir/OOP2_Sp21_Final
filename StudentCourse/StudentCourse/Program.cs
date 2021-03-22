using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Mushfiqur Rahman", "19-40008-1", 3.57F);
            var s2 = new Student("Mahabubur Rahman", "21-35643-2", 3.75F);

            var c1 = new Course("OOP1", "CS01");
            var c2 = new Course("OOP2", "CS02");
 
            c1.AddStudent(s1, s2);
            c1.PrintStudent();

            c1.RemoveStudent(s2);

            Console.WriteLine("\nAfter Removing Student\n");

            s1.PrintCourse();
            c1.PrintStudent();

            Console.WriteLine("\n**************\n");

            s2.AddCourse(c1, c2);
            s2.PrintCourse();

            s2.RemoveCourse(c2);
            Console.WriteLine("\nAfter Dropping Course\n");
            s2.PrintCourse();
            c2.PrintStudent();
        }
    }
}
