using System;
using System.Collections.Generic;
using System.Text;

namespace _234P2
{
    public class MainStore
    {

        StoreLogic _logic = new StoreLogic();

        public void StoreInterface(Customer _customer)
        {
            string _selectionPlace = "Your Input :";
            _logic.SellingBuyingHandler();
            _logic.UserLocationHandler();

            Console.Clear();
            Console.WriteLine("Welcome to the Store, " + _customer.customerName);
            Console.WriteLine("------------------- \n");
            Console.WriteLine(_logic._storeMessage);
            Console.WriteLine("------------------- \n");
            Console.WriteLine(_selectionPlace);
            Console.WriteLine(_logic._warningMessage + "\n");
            Console.WriteLine(_customer.MyList());
            Console.SetCursorPosition(_selectionPlace.Length + 1, 9);



            try
            {
                int _userinput = Convert.ToInt32(Console.ReadLine());
                _logic._warningMessage = "";
                _logic.MainLogic(_userinput, _customer);
                this.StoreInterface(_customer);
            }
            catch (FormatException)
            {
                _logic._warningMessage = "That was not a Number";
                this.StoreInterface(_customer);
            }
        }
    }
}

        
      