using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class MaintenanceController
    {

        public static void DoScheduleMaintainTime(String startTime, String endTime, int id)
        {
            HeaderMaintenance headerMaintenance = new HeaderMaintenance();
            headerMaintenance.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            headerMaintenance.RideId = id;
            headerMaintenance.StartTime = Convert.ToDateTime(startTime);
            headerMaintenance.EndTime = Convert.ToDateTime(endTime);

            ConnectionController.GetInstance().HeaderMaintenances.Add(headerMaintenance);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoChangeMaintainStatus(int id)
        {
            HeaderMaintenance headerMaintenance;
            headerMaintenance = ConnectionController.GetInstance().HeaderMaintenances.Where(x => x.Id.Equals(id)).FirstOrDefault();
            Ride ride;
            ride = RideCreationController.DoSearchRide(headerMaintenance.RideId);
 
            if (ride.RideMaintainStatus.Equals("Yes"))
            {
                ride.RideMaintainStatus = "No";
            }
            else
            {
                ride.RideMaintainStatus = "Yes";
            }
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
