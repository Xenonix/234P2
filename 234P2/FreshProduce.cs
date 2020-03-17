using System;
using System.Collections.Generic;
using System.Text;

namespace _234P2
{
    public class FreshProduce : Product
    {
        public FreshProduce()
        {
            Name = "Fresh Produce";
            Amount = 0;

        }
        public override string Name {get; set;}
        public override int Amount {get; set;}
    }
}
