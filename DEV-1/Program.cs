﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    System.Console.WriteLine("3*" + i / 3);
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }

            System.Console.Read();
            
        }
    }
}
