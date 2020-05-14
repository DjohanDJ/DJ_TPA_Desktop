using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class RideTypeController
    {

        public static RideType FindRideTypeByName(String rideTypeName)
        {
            RideType rideType;
            rideType = ConnectionController.GetInstance().RideTypes.Where(x => x.RideTypeName.Equals(rideTypeName)).FirstOrDefault();
            return rideType;
        }

    }
}
