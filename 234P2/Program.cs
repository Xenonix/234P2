using System;

namespace _234P2
{

    class Program
    {
        static void Main()
        {
            var _customer = new Customer();
            var _mainStore = new MainStore();

            _customer.SetCustomerName();
            _mainStore.StoreInterface(_customer);

            
        }


    }
}
 

