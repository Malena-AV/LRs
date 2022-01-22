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

            IFlyBehavior flyBehavior = new FlyNoWay();
            IQuackBehavior quackBehavior = new DQuack();

            mal.FlyBehavior(flyBehavior);
            rub.QuackBehavior(quackBehavior);

            Duck[] ducks = new Duck[]{ mal, red, dec, rub };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display()); 
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].PerformFly());
                Console.WriteLine(ducks[i].PerformQuack()+"\n");
            }

            Console.ReadKey();
        }
    }
}
