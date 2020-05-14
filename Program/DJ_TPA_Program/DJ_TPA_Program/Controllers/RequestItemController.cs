using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class RequestItemController
    {

        public static void DoPurchaseRequest(String itemName, String itemDesc, int qty)
        {
            ItemPiece itemPiece = new ItemPiece();
            itemPiece.ItemName = itemName;
            itemPiece.ItemDescription = itemDesc;
            itemPiece.ItemPrice = 0;
            ConnectionController.GetInstance().ItemPieces.Add(itemPiece);
            ConnectionController.GetInstance().SaveChanges();

            HeaderPurchaseRequest headerPurchaseRequest = new HeaderPurchaseRequest();
            headerPurchaseRequest.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            headerPurchaseRequest.ItemPieceId = itemPiece.Id;
            headerPurchaseRequest.RequestDate = DateTime.Now;
            headerPurchaseRequest.ResponseStatus = "Waiting";
            headerPurchaseRequest.Quantity = qty;
            ConnectionController.GetInstance().HeaderPurchaseRequests.Add(headerPurchaseRequest);
            ConnectionController.GetInstance().SaveChanges();
        }

        public static void DoFundRequest(int money, String desc, bool fromPurchaseDepartment)
        {
            HeaderFundRequest headerFundRequest = new HeaderFundRequest();
            headerFundRequest.PriceValue = money;
            headerFundRequest.Description = desc;
            headerFundRequest.ResponseStatus = "Waiting";
            headerFundRequest.EmployeeId = ActiveUserController.GetActiveEmployee().Id;
            if (fromPurchaseDepartment)
            {
                HeaderPurchaseRequest headerPurchaseRequest = ConnectionController.GetInstance().HeaderPurchaseRequests.Where(x => x.ItemPiece.ItemPrice.Equals(money)).FirstOrDefault();
                headerFundRequest.PurchaseId = headerPurchaseRequest.Id;
            }
            ConnectionController.GetInstance().HeaderFundRequests.Add(headerFundRequest);
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
