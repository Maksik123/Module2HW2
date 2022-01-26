using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class RunAppService
    {
        ShowProductService showProductService = new ShowProductService();
        UsersChoice usersChoice = new UsersChoice();

        public void Run()
        {
            showProductService.ShowProducts();
            usersChoice.Choice();
        }
    }
}
