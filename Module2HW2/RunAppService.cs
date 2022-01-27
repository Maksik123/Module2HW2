using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class RunAppService
    {
        Catalogue catalogue = new Catalogue();
        ShoppingCart cart = new ShoppingCart();

        public void Run()
        {
            int counter = 0;
            int usersText = 0;
            catalogue.ShowProductsInConsole();
            Console.WriteLine("Enter ID:");
            string input = Console.ReadLine();
            bool isString = int.TryParse(input, out usersText);
            switch (usersText)
            {
                case 1:
                        System.Array.Copy(cart.ourShoppingCart, catalogue.OurCatalogue, 1);

                    break;
                case 2:
                    cart.ourShoppingCart[counter] = catalogue.OurCatalogue[1];
                    break;
                default:
                    Console.WriteLine("Error, try more");
                    break;
            }

            foreach (Products i in cart.ourShoppingCart)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
