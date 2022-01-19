using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MallardDuck : Duck
    {
        public override string DisPlay()
        {
            return "DisPlay" + " " + this.GetType();
        }
    }
}
