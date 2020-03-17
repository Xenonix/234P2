using System;

namespace _234P2
{
   public class Groceries : Product
    {
        public Groceries()
        {
            Name = "Random Groceries";
            Amount = 0;
        }
        public override string Name { get; set;}
        public override int Amount { get; set;}
    }
    
}
