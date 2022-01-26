using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class ShowProductService
    {
        Products products = new Products();

        public void ShowProducts()
        {
            Console.WriteLine("Our products:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}. {products.Cars[i]}");
            }
        }
    }
}
