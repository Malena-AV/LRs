﻿using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mal = new MallardDuck();
            Duck red = new RedheadDuck();

            Duck[] duck = new Duck[] { mal, red };

            for (int i = 0; i < duck.Length; i++)
            {
                Console.WriteLine(duck[i].Quack());
                Console.WriteLine(duck[i].Swim());
                Console.WriteLine(duck[i].DisPlay());
            }

            Console.ReadKey();
        }
    }
}
