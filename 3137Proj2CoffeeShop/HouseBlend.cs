using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3137Proj2CoffeeShop
{
    public class HouseBlend : Drink
    {
        protected IBrewer brewer;
        public override decimal Cost()
        {
            return 1.50m;
        }
        public override string Description()
        {
            return "House Blend Coffee";
        }
        public override void Prepare()
        {
            brewer.Brew(Description());
        }
    }
}
