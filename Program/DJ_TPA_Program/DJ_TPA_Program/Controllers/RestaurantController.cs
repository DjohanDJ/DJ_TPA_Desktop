using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class RestaurantController
    {

        public static void DoCreateOrder(int id)
        {
            OrderRequest orderReq = ConnectionController.GetInstance().OrderRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();
            orderReq.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            orderReq.OrderStatus = "Pending";
            ConnectionController.GetInstance().SaveChanges();

            Table table = ConnectionController.GetInstance().Tables.Where(x => x.Id.Equals(orderReq.TableNumber)).FirstOrDefault();
            table.TableStatus = "Unavailable";

            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoChangeToEat(int id)
        {
            OrderRequest orderReq = ConnectionController.GetInstance().OrderRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();
            orderReq.OrderStatus = "Eating";
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoChangeToCooked(int id)
        {
            OrderRequest orderReq = ConnectionController.GetInstance().OrderRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();
            orderReq.OrderStatus = "Cooked";
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoChangeToDone(int id)
        {
            OrderRequest orderReq = ConnectionController.GetInstance().OrderRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();
            orderReq.OrderStatus = "Done";
            ConnectionController.GetInstance().SaveChanges();

            Table table = ConnectionController.GetInstance().Tables.Where(x => x.Id.Equals(orderReq.TableNumber)).FirstOrDefault();
            table.TableStatus = "Available";
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
