using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja kirby =  new Ninja();
            Buffet newBuffet = new Buffet();
            while(!kirby.IsFull)
            {
                kirby.Eat(Buffet.Serve());
            }
        }
    }
}
