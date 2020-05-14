using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class FundRequestController
    {

        public static void DoResponse(int id, String status)
        {
            HeaderFundRequest headerFundRequest;
            headerFundRequest = ConnectionController.GetInstance().HeaderFundRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();

            headerFundRequest.ResponseStatus = status;
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
