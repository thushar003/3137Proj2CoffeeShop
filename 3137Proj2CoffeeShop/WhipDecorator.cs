using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public class WhipDecorator : DrinkDecorator
    {
        public override decimal Cost()
        {
            return inner.Cost() + 0.40m;
        }
        public override string Description()
        {
            return inner.Description() + ", Whip";
        }
        public override void Prepare()
        {
            inner.Prepare();
            Console.WriteLine("[Decorator] Adding Whip...");
        }
    }
}
