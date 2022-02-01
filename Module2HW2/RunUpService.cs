using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class RunUpService
    {
        public void Run()
        {
            CatalogueService catalogueService = new CatalogueService();
            ShoppingCartService cart = new ShoppingCartService();
            Catalogue catalogue = new Catalogue();
            catalogueService.ShowProductsInConsole();
            Products getOneProduct = new Products();
            string userText = string.Empty;
            while (userText != "Exit")
            {
                Console.WriteLine("\nUse commands:\nShow to Show Your ShoppingCart\nEmpty to Empty Your Shopping Cart\n" +
                    "Order to form Yor order\nExit to exit programm\nPrint Id of product what you want to add:");
                userText = Console.ReadLine();
                bool isInt = int.TryParse(userText, out int userTextToInt);
                if (!isInt)
                {
                    switch (userText)
                    {
                        case "Show":
                            cart.ShowShoppingCart();
                            break;
                        case "Empty":
                            cart.EmptyingTheShoppingCart();
                            break;
                        case "Order":
                            cart.GenerateOrder();
                            break;
                        default:
                            Console.WriteLine("Error: Unnkown command");
                            break;
                    }
                }
                else
                {
                    if (userTextToInt > catalogue.OurCatalogue.Length)
                    {
                        Console.WriteLine("Unknown product id");
                    }
                    else
                    {
                        getOneProduct = catalogueService.GetOneProduct(userTextToInt);
                        cart.AddOneProductToTheShoppingCart(getOneProduct);
                    }
                }
            }
        }
    }
}
