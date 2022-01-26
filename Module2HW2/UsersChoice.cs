using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class UsersChoice
    {
        public string Choice()
        {
            Order order = new Order();
            Console.WriteLine("Please write number of products would you like to add to the shoping cart:");
            string userChoice = Console.ReadLine().Trim();
            string Error = "Error: Please enter your choice again";

            if (userChoice != String.Empty )
            {
                if (userChoice == "0")
                {
                    return order.AddingToTheBasket();
                }

                return Error;
            }
            else
            {
                Console.WriteLine("Error: Please enter your choice again");
                return Error;
            }
        }
    }
}