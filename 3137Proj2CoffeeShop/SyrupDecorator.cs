using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public class SyrupDecorator : DrinkDecorator
    {
        public override decimal Cost()
        {
            return inner.Cost() + 0.50m;
        }
        public override string Description()
        {
            return inner.Description() + ", Syrup";
        }
        public override void Prepare()
        {
            inner.Prepare();
            Console.WriteLine("[Decorator] Adding Syrup...");
        }
    }
}
