using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class CatalogueService
    {
        Catalogue catalogue = new Catalogue();

        public void ShowProductsInConsole()
        {
            Console.WriteLine("Our Products:");
            foreach (Products i in catalogue.OurCatalogue)
            {
                Console.WriteLine($"Id: {i.Id} Name: {i.Name} Price: {i.Price}");
            }
        }

        public Products[] GetAllProducts()
        {
            return catalogue.OurCatalogue;
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
