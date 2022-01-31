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
    }
}
