﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehLib;

namespace VehicleType
{
    class Class1
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("I20", "Red", 0, 4, 0);
            Vehicle bus = new Vehicle("TATA", "White", 2, 6, 2);

            car.Start();
            car.Display();
            car.Stop();

            Console.WriteLine();
            Console.WriteLine();

            bus.Start();
            bus.Display();
            bus.Stop();
            Console.Read();

        }
        


    }
    /*public class Class1
    {
        static void Main()
        {

        }
    }*/
}
