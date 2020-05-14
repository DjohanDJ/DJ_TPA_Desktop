using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DJ_TPA_Program.Controllers
{
    class RideCreationController
    {

        private static String[] rideData = new String[10];
        private static String[] headerDetailData = new String[10];
        private static int changeRide = 0;

        public static void DoPrepareRide(String rideName, String rideDurability, String quantity)
        {
            rideData[0] = rideName;
            rideData[1] = rideDurability;
            headerDetailData[0] = quantity;
        }

        public static void DoPrepareRideChange(int id, String rideName, String rideDurability, String quantity)
        {
            changeRide = id;
            rideData[0] = rideName;
            rideData[1] = rideDurability;
            headerDetailData[0] = quantity;
        }

        public static void DoPrepareType(String rideType)
        {
            rideData[2] = rideType;
        }

        public static void DoPrepareSafety(String force)
        {
            int forceInt;
            Int32.TryParse(force, out forceInt);
            rideData[3] = force;
            if (forceInt < 100)
            {
                rideData[4] = "Safe";
            }
            else
            {
                rideData[4] = "Danger";
            }
            rideData[5] = "Unavailable";
            rideData[6] = "No";
        }

        public static void DoInsertRide()
        {
            RideType rideType = RideTypeController.FindRideTypeByName(rideData[2]);
            RideSafety rideSafety = RideSafetyController.FindRideSafetyByName(rideData[4]);

            int rideDurability, rideForce;
            Int32.TryParse(rideData[1], out rideDurability);
            Int32.TryParse(rideData[3], out rideForce);

            Ride ride = new Ride();
            ride.RideName = rideData[0];
            ride.RideDurabilityCheckPerWeek = rideDurability;
            ride.RideTypeId = rideType.Id;
            ride.RideSafetyId = rideSafety.Id;
            ride.RideStatus = rideData[5];
            ride.RideMaintainStatus = rideData[6];
            ride.RideForce = rideForce;

            ConnectionController.GetInstance().Rides.Add(ride);
            ConnectionController.GetInstance().SaveChanges();

            DoInsertHeader();
            DoInsertDetail();
        }

        public static void DoChangeRide()
        {
            Ride ride;
            ride = DoSearchRide(changeRide);

            RideType rideType = RideTypeController.FindRideTypeByName(rideData[2]);
            RideSafety rideSafety = RideSafetyController.FindRideSafetyByName(rideData[4]);

            int rideDurability, rideForce;
            Int32.TryParse(rideData[1], out rideDurability);
            Int32.TryParse(rideData[3], out rideForce);

            ride.RideName = rideData[0];
            ride.RideDurabilityCheckPerWeek = rideDurability;
            ride.RideTypeId = rideType.Id;
            ride.RideSafetyId = rideSafety.Id;
            ride.RideStatus = rideData[5];
            ride.RideMaintainStatus = rideData[6];
            ride.RideForce = rideForce;
            
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoDeleteRide(int id)
        {
            Ride ride = DoSearchRide(id);
            ConnectionController.GetInstance().Rides.Remove(ride);
            ConnectionController.GetInstance().SaveChanges();
        }

        private static void DoInsertHeader()
        {
            HeaderCreation headerCreation = new HeaderCreation();

            headerCreation.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            headerCreation.CreatedDate = DateTime.Now;

            ConnectionController.GetInstance().HeaderCreations.Add(headerCreation);
            ConnectionController.GetInstance().SaveChanges();
        }
        
        private static int DoSearchMaxHeaderId()
        {
            int i = 0;
            if (ConnectionController.GetInstance().HeaderCreations.ToList().Count() > 0)
            {
                i = ConnectionController.GetInstance().HeaderCreations.Max(x => x.Id);
            }
            return i;
        }

        private static int DoSearchRideId(String rideName)
        {
            Ride ride;
            ride = ConnectionController.GetInstance().Rides.Where(x => x.RideName.Equals(rideName)).FirstOrDefault();
            return ride.Id;
        }

        private static void DoInsertDetail()
        {
            DetailCreation detailCreation = new DetailCreation();

            int quantity;
            Int32.TryParse(headerDetailData[0], out quantity);
            detailCreation.Quantity = quantity;
            detailCreation.HeaderId = DoSearchMaxHeaderId();
            detailCreation.RideId = DoSearchRideId(rideData[0]);

            ConnectionController.GetInstance().DetailCreations.Add(detailCreation);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static Ride DoSearchRide(int id)
        {
            Ride ride;
            ride = ConnectionController.GetInstance().Rides.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return ride;
        }

    }
}
