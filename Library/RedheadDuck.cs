﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RedheadDuck : Duck, IQuackable, IFlyable
    {
        public override string DisPlay()
        {
            return "DisPlay" + " " + this.GetType();
        }
        public string Quack()
        {
            return "Quackable" + " " + this.GetType();
        }
        public string Fly()
        {
            return "Flyable" + " " + this.GetType();
        }
    }
}
