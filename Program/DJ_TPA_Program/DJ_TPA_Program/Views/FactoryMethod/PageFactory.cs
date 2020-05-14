using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Views.FactoryMethod
{
    public class PageFactory
    {

        public static Object GetInstance(String pageType)
        {
            if (pageType.Equals("Creative"))
            {
                return new CreativePage().render();
            }
            else if (pageType.Equals("Maintenance"))
            {
                return new MaintenancePage().render();
            }
            else if (pageType.Equals("Construction"))
            {
                return new ConstructionPage().render();
            }
            else if (pageType.Equals("Kitchen"))
            {
                return new KitchenPage().render();
            }
            else if (pageType.Equals("Dining"))
            {
                return new DiningPage().render();
            }
            else if (pageType.Equals("Purchase"))
            {
                return new PurchasePage().render();
            }
            else if (pageType.Equals("Sales"))
            {
                return new SalesPage().render();
            }
            else if (pageType.Equals("HRD"))
            {
                return new HRDPage().render();
            }
            else if (pageType.Equals("Finance"))
            {
                return new FinancePage().render();
            }
            else if (pageType.Equals("Manager"))
            {
                return new ManagerPage().render();
            }
            return null;
        }

    }
}
