using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class ShoppingCart
    {
        public Products[] ourShoppingCart = new Products[0];

        public int ShoppingCartId { get; set; }

        public decimal OrderPrice { get; set; }

        private decimal Price { get; set; }

        private int Counter { get; set; }

        public void AddOneProductToTheShoppingCart(Products product)
        {
            Array.Resize(ref ourShoppingCart, Counter + 1);
            ourShoppingCart[Counter] = product;
            Counter++;
        }

        public void EmptyingTheShoppingCart()
        {
            ourShoppingCart = new Products[0];
            OrderPrice = 0;
        }

        public void Summ()
        {
            foreach (Products product in ourShoppingCart)
            {

                OrderPrice += product.Price;
            }
        }

        public void ShowShoppingCart()
        {
            foreach (Products product in ourShoppingCart)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Price}");
            }
        }

        public void GenerateOrder()
        {
            Summ();
            ShoppingCartId = ++ShoppingCartId;
            Console.WriteLine($"\nYour order number is {ShoppingCartId}\nOrder price {OrderPrice}");
            ShowShoppingCart();
            EmptyingTheShoppingCart();
        }
    }
}