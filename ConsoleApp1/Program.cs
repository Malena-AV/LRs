using Library;
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
            Duck dec = new DecoyDuck();
            Duck rub = new RubberDuck();

            Duck[] ducks = new Duck[]{ mal, red, dec, rub };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                if (ducks[i] is IFlyable)
                {
                    Console.WriteLine((ducks[i] as IFlyable).Fly());
                }
                if (ducks[i] is IQuackable)
                {
                    Console.WriteLine((ducks[i] as IQuackable).Quack());
                }
            }

            Console.ReadKey();
        }
    }
}
