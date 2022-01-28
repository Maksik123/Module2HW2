using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Catalogue
    {
        public Products[] OurCatalogue = new[]
        {
            new Products() { Name = "Lada", Id = 1, Price = 10 },
            new Products() { Name = "BMW", Id = 2, Price = 15 },
            new Products() { Name = "KIA", Id = 3, Price = 7 },
        };

        public void ShowProductsInConsole()
        {
            Console.WriteLine("Our Products:");
            foreach (Products i in OurCatalogue)
            {
                Console.WriteLine($"Id: {i.Id} Name: {i.Name} Price: {i.Price}");
            }
        }

        public Products[] GetAllProducts()
        {
            return OurCatalogue;
        }

        public Products GetOneProduct(int id)
        {
            foreach (Products product in GetAllProducts())
            {
                if (product.Id == id)
                {
                    return product;
                }
            }

            return new Products();
        }
    }
}
