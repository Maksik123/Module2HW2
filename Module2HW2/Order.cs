using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class Order
    {
        UsersChoice ChoiseOfUser = new UsersChoice();
        ShoppingCart shopping = new ShoppingCart();

        public string AddingToTheBasket()
        {
            shopping.usersShoppingCart += (ChoiseOfUser.Choice());
            return Console.WriteLine($"Your shopping cart contains: {shopping.usersShoppingCart}");
        }
    }
}
