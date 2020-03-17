using System;
using System.Collections.Generic;
using System.Text;

namespace _234P2
{
    public class GroceryList
    {
        private readonly Product[] _producten = new Product[2];
        
        public GroceryList()
        {

            _producten[0] = new Groceries();
            _producten[1] = new FreshProduce();
            
        }
        public string MyGroceryList()
        {
            string _currentList = "";
            for (int i = 0; i < _producten.Length; i++)
            {
                if (_producten[i].Amount > 0)
                {
                    _currentList = _currentList + _producten[i].Name + "  ||  " + _producten[i].Amount + "\n";
                }
            }

            if (_currentList == string.Empty)
            {
                _currentList = "No items added in Shopping Bag";
            }

            return _currentList;
            
        }
        public void AddRemProducts(int type, int numItems, bool _selling)
        {
            type -= 1;
            if (_producten[type].Amount <= 0)
                _producten[type].Amount = 0;
            else
                if (_selling)
            {
                numItems = -Math.Abs(numItems);
            }
                else
            {
                numItems = +Math.Abs(numItems);
            }
            _producten[type].Amount += numItems;


        }
        
    }
}
