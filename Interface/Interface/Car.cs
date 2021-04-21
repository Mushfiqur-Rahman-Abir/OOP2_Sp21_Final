using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Car
    {
        public string EngineNo { get; set; }

        public string ChassisNo { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Engine No: " + EngineNo);
            Console.WriteLine("Chassis No: " + ChassisNo);

        }
    }
}
