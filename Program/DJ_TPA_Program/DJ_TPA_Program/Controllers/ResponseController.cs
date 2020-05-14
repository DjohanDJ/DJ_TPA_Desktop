using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class ResponseController
    {

        public static void DoRequestManager(int id)
        {
            Ride ride;
            ride = RideCreationController.DoSearchRide(id);

            HeaderResponse headerResponse = new HeaderResponse();
            headerResponse.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            headerResponse.ResponseDate = DateTime.Now;
            headerResponse.ResponseStatus = "Waiting";
            headerResponse.RideId = ride.Id;

            ConnectionController.GetInstance().HeaderResponses.Add(headerResponse);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoSendToConstructionDepartment(int id)
        {
            HeaderResponse headerResponse;
            headerResponse = ConnectionController.GetInstance().HeaderResponses.Where(x => x.Id.Equals(id)).FirstOrDefault();
            Ride ride;
            ride = RideCreationController.DoSearchRide(headerResponse.RideId);

            HeaderConstruction headerConstruction = new HeaderConstruction();
            headerConstruction.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            headerConstruction.ConstructionRequestDate = DateTime.Now;
            headerConstruction.RideId = ride.Id;

            ride.RideStatus = "On Going";

            ConnectionController.GetInstance().HeaderConstructions.Add(headerConstruction);
            ConnectionController.GetInstance().SaveChanges();

        }

        public static void DoChangeStatus(int id)
        {
            HeaderConstruction headerConstruction;
            headerConstruction = ConnectionController.GetInstance().HeaderConstructions.Where(x => x.Id.Equals(id)).FirstOrDefault();
            Ride ride;
            ride = RideCreationController.DoSearchRide(headerConstruction.RideId);
            ride.RideStatus = "Available";
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
