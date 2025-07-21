/**
 * Program Name: Drink.cs
 * Authors: Thushar Joseph Joji, Manny Bagheri
 * Date: July 19, 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public abstract class Drink
    {
        public abstract void Prepare();
        public abstract decimal Cost();
        public abstract string Description();
    }
}
