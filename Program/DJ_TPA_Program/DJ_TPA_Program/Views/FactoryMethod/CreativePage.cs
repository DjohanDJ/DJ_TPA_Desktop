using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Views.FactoryMethod
{
    class CreativePage : PageInterface
    {
        public Object render()
        {
            return new CreativeHomePage();
        }
    }
}
