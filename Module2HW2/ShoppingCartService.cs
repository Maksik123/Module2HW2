using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class ShoppingCartService
    {
        ShoppingCart shoppingCart = new ShoppingCart();

        public void AddOneProductToTheShoppingCart(Products product)
        {
            Array.Resize(ref shoppingCart.ourShoppingCart, shoppingCart.Counter + 1);
            shoppingCart.ourShoppingCart[shoppingCart.Counter] = product;
            shoppingCart.Counter++;
        }

        public void EmptyingTheShoppingCart()
        {
            shoppingCart.ourShoppingCart = new Products[0];
            shoppingCart.OrderPrice = 0;
        }

        public void Summ()
        {
            foreach (Products product in shoppingCart.ourShoppingCart)
            {

                shoppingCart.OrderPrice += product.Price;
            }
        }

        public void ShowShoppingCart()
        {
            foreach (Products product in shoppingCart.ourShoppingCart)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Price}");
            }
        }

        public void GenerateOrder()
        {
            Summ();
            shoppingCart.ShoppingCartId = ++shoppingCart.ShoppingCartId;
            Console.WriteLine($"\nYour order number is {shoppingCart.ShoppingCartId}\nOrder price {shoppingCart.OrderPrice}");
            ShowShoppingCart();
            EmptyingTheShoppingCart();

        }
    }
}