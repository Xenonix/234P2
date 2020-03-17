using System;
using System.Collections.Generic;
using System.Text;

namespace _234P2
{
    public class Customer
    {
        public string customerName { get; set; } = string.Empty;
        
        private GroceryList MyGroceryList = new GroceryList();

        public string MyList()
        {
            string _myList = MyGroceryList.MyGroceryList() + "\n";

            string MyList = "-----------------Current items in Shopping bag----------------- \n" + _myList + "---------------------------------------------------------------";

            return MyList;
            
        }
        
        public void AddRemoveProducts(int _userinput, bool _selling, int _productType)
        {
            MyGroceryList.AddRemProducts(_productType, _userinput, _selling);
        }

        public void SetCustomerName()
        {
            string question = "Please enter your name: ";
            Console.WriteLine("Welcome Customer, what is your name?");
            Console.WriteLine(question);
            Console.SetCursorPosition(question.Length + 1, 1);
            this.customerName = Console.ReadLine();
        }
    }
}
