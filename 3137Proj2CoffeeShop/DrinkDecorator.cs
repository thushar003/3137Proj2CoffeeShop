using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public abstract class DrinkDecorator : Drink
    {
        protected Drink inner;
    }
}
