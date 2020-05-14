using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class RideSafetyController
    {

        public static RideSafety FindRideSafetyByName(String rideSafetyName)
        {
            RideSafety rideSafety;
            rideSafety = ConnectionController.GetInstance().RideSafeties.Where(x => x.RideSafetyName.Equals(rideSafetyName)).FirstOrDefault();
            return rideSafety;
        }

    }
}
