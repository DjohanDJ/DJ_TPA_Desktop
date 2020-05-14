using DJ_TPA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_TPA_Program.Controllers
{
    class PurchaseRequestController
    {

        private static String money = "";

        public static void DoFeedItemMoney(int id, int money)
        {
            HeaderPurchaseRequest headerPurchaseReq;
            headerPurchaseReq = ConnectionController.GetInstance().HeaderPurchaseRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();

            ItemPiece itemPiece;
            itemPiece = ConnectionController.GetInstance().ItemPieces.Where(x => x.Id.Equals(headerPurchaseReq.ItemPieceId)).FirstOrDefault();

            headerPurchaseReq.ResponseStatus = "Pending";
            itemPiece.ItemPrice = money;
            ConnectionController.GetInstance().SaveChanges();
        }

        public static String DoFeedMoney()
        {
            return money;
        }

        public static void DoSetMoney(int price)
        {
            money = price.ToString();
        }

        public static void DoBuyMaterial(int id)
        {
            ConnectionController.GetInstance().SaveChanges();
            HeaderFundRequest headerFundRequest = ConnectionController.GetInstance().HeaderFundRequests.Where(x => x.Id.Equals(id)).FirstOrDefault();
            headerFundRequest.ResponseStatus = "Done";
            ConnectionController.GetInstance().SaveChanges();
        }

    }
}
