﻿using DesignPattern.Strategy.SimUDuck.FlyBehaviors;
using DesignPattern.Strategy.SimUDuck.QuackBehaviors;
using System;

namespace DesignPattern.Strategy.SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("[*][Mallard Duck]");
        }
    }
}
