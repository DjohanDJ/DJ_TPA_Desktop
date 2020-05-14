using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Views.FactoryMethod
{
    class SalesPage : PageInterface
    {
        public object render()
        {
            return new SalesMarketingHomePage();
        }
    }
}
