﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ing;
            int count = 0;
            while ((ing=Console.ReadLine())!="Bake!")
            {
                count++;
                Console.WriteLine($"Adding ingredient {ing}.");
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
