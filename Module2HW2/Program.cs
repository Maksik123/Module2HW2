using Module2HW2;

public class Program
{
    public static void Main()
    {
        Catalogue catalogue = new Catalogue();
        ShoppingCart cart = new ShoppingCart();
        catalogue.ShowProductsInConsole();
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
                    getOneProduct = catalogue.GetOneProduct(userTextToInt);
                    cart.AddOneProductToTheShoppingCart(getOneProduct);
                }
            }
        }
    }
}