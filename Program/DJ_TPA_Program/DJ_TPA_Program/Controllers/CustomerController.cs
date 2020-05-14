using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DJ_TPA_Program.Controllers
{
    class CustomerController
    {

        private static String tableNumber;

        public static void InsertCustomer(String[] customerData)
        {

            Customer customer = new Customer();
            customer.CustomerFullname = customerData[0];
            customer.CustomerEmail = customerData[1];
            customer.CustomerPhoneNumber = customerData[2];
            customer.CustomerAddress = customerData[3];
            customer.CustomerGender = customerData[4];
            customer.CustomerUsername = customerData[5];
            customer.CustomerPassword = customerData[6];

            ConnectionController.GetInstance().Customers.Add(customer);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static String[] DoSearchCustomer(String username, String password)
        {
            String[] messages = { "", "" };

            Customer customer = ConnectionController.GetInstance().Customers.Where(x => x.CustomerUsername.Equals(username) && x.CustomerPassword.Equals(password)).FirstOrDefault();

            if (customer == null)
            {
                messages[1] = "Invalid Credential";
                return messages;
            }

            messages[0] = customer.Id.ToString();

            return messages;
        }

        public static Customer DoSearchCustomer(int id)
        {
            Customer customer = ConnectionController.GetInstance().Customers.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return customer;
        }

        public static void DoOrderTable(String id)
        {
            tableNumber = id;
        }

        public static void DoOrderFood(String id, String quantity)
        {
            int foodId, quantityId, tableNumberId;
            Int32.TryParse(id, out foodId);
            Int32.TryParse(quantity, out quantityId);
            Int32.TryParse(tableNumber, out tableNumberId);

            OrderRequest orderReq = new OrderRequest();
            orderReq.CustomerId = ActiveUserController.GetActiveCustomer().Id;
            orderReq.OrderDate = DateTime.Now;
            orderReq.EmployeeId = 1;
            orderReq.TableNumber = tableNumberId;
            orderReq.OrderStatus = "Waiting";
            orderReq.FeedBackCustomer = "None";
            ConnectionController.GetInstance().OrderRequests.Add(orderReq);
            ConnectionController.GetInstance().SaveChanges();


            OrderDetail orderDetail = new OrderDetail();
            orderDetail.FoodId = foodId;
            orderDetail.Quantity = quantityId;
            orderDetail.OrderId = orderReq.Id;

            ConnectionController.GetInstance().OrderDetails.Add(orderDetail);
            ConnectionController.GetInstance().SaveChanges();

            
        }

        public static void DoGiveFeedback(String id, String feedback)
        {
            int orderId;
            Int32.TryParse(id, out orderId);

            OrderRequest orderReq = ConnectionController.GetInstance().OrderRequests.Where(x => x.Id.Equals(orderId)).FirstOrDefault();

            orderReq.FeedBackCustomer = feedback;
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
