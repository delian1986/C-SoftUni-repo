﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.evenOrOdd
{
    class evenOrOdd
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number %2 ==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
