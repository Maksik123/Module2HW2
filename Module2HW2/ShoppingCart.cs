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

        public int Counter { get; set; }
    }
}