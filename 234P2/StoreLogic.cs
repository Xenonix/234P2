using System;
using System.Collections.Generic;
using System.Text;

namespace _234P2
{
    public class StoreLogic
    {
        public bool _sellling { get; set; } = false;
        public string _storeMessage { get; set; }
        public int _customerLocation { get; set; } = 0;
        public string _warningMessage = "";
        string _action { get; set; }
        string _lastMenuOption { get; set; }
        
        


        public void SellingBuyingHandler()
        {
            if (_sellling)
            {
                _action = "remove? ";
                _lastMenuOption = "Buy items from Store";
            }
            else
            {
                _action = "add? ";
                _lastMenuOption = "Remove items from Inventory";
            }
        }
        public string UserLocationHandler()
        {
            switch (_customerLocation)
            {

                case 0:
                    _storeMessage = "What would you like to " + _action + "\n 1. Groceries \n" +
                                    " 2. Fresh Produce \n 3. " + _lastMenuOption;
                    break;

                case 1:
                    _storeMessage = "How many grocery's do you want to " + _action + "\n" +
                                    "Type '0' to go back to the main store.\n\n";
                    break;
                case 2:
                    _storeMessage = "How many Fresh Produce do you want to " + _action + "\n" +
                                    "Type '0' to go back to the main store.\n\n";
                    break;


            }

            return _storeMessage;

        }
        public void MainLogic(int _userInput, Customer _customer)
        {
            if (_customerLocation == 0)
            {
                _customerLocation = _userInput;
                if (_userInput == 3)
                {
                    _sellling = !_sellling;
                    _customerLocation = 0;
                }
            }
            else if (_customerLocation == 1 || _customerLocation == 2)
            {
                if (_userInput == 0)
                {
                    _customerLocation = 0;
                }
                else
                {
                    _customer.AddRemoveProducts(_userInput, _sellling, _customerLocation);
                }
            }
           else
                _warningMessage = "That wat not a valid option"; 
        }
    }
}
