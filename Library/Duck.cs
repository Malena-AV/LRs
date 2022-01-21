using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        public string Swim()
        {
            return "буль буль буль";
        }
        public string Display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }
        public string Fly()
        {
            return flyBehavior.Fly();
        }
        public string Quack()
        {
            return quackBehavior.Quack();
        }
    }
}
