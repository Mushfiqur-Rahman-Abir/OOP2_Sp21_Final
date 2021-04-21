using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Course c = new Course();
            Course c2 = new Course();
            Course c3 = new Course();

            list.Add(c);
            list.Insert(1, c2);
            bool rs = list.Contains(c3);
            int i = list.IndexOf(c2);
            Console.WriteLine("Index of c is:" +rs);

            Hashtable ages = new Hashtable();
            ages["Sabbir"] = 28;
            ages["Rahim"] = 21;
            ages["Karim"] = 25;
            ages.Add("Sagor", 34);

            foreach(DictionaryEntry age in ages)
            {
                string a =(string) age.Key;
                int b = (int)age.Value;
                Console.WriteLine("{0} => {1}", a, b);
               //Console.WriteLine("Value is: " + age.Value+ " " +age.Key);
            }

            Console.WriteLine("Age of Sabbir " + ages["Sabbir"]);

            SortedList sl = new SortedList();

            sl["en-us"] = "United States";
            sl["en-uk"] = "United Kingdom";
            sl["bn"] = "Bangle";
            sl["in"] = "India";
            sl["ar"] = "Arabic";

            foreach (DictionaryEntry s in sl)
            {
                string a = (string)s.Key;
                string b = (string)s.Value;
                Console.WriteLine("{0} => {1}", a, b);
                
            }

            /*int k = 10;
            object box = k;
            Console.WriteLine(k.GetType());
            k = (int)box;

            Course c5 = new Course();
            box = c5;
            Console.WriteLine(box.GetType());
            c5 = (Course)box;*/
        }
    }
}
