using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public class Espresso : Drink
    {
        protected IBrewer brewer;
        public override decimal Cost()
        {
            return 2.00m;
        }
        public override string Description()
        {
            return "Espresso";
        }
        public override void Prepare()
        {
            brewer.Brew(Description());
        }
    }
}
