using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public class ManualSteamer : IBrewer
    {
        public void Brew(string description)
        {
            Console.WriteLine("[Manual] Brewing " + description + "...");
        }
    }
}
