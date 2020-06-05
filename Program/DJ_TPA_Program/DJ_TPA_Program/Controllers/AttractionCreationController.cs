using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class AttractionCreationController
    {

        public static void DoInsertAttraction(String attName, int durabilityCheck, int quantity, String startDate)
        {
            Attraction attraction = new Attraction();
            attraction.AttractionName = attName;
            attraction.DurationInDays = durabilityCheck;
            attraction.StartDate = Convert.ToDateTime(startDate);

            ConnectionController.GetInstance().Attractions.Add(attraction);


            HeaderAttraction headerAtt = new HeaderAttraction();
            headerAtt.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            headerAtt.CreatedDate = DateTime.Now;
            headerAtt.Area_Quantity = quantity;
            headerAtt.AttractionId = attraction.Id;

            ConnectionController.GetInstance().HeaderAttractions.Add(headerAtt);
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
