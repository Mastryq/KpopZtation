using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Model;

namespace KpopZtation.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader createHeader(int CustomerID)
        {
            TransactionHeader header = new TransactionHeader();
            header.CustomerId = CustomerID;

            DateTime currentTime = DateTime.Now;
            header.TransactionDate = currentTime;

            return header;
        }

        public static TransactionDetail createDetails(int TransactionID, Cart cart)
        {
            TransactionDetail detail = new TransactionDetail();

            detail.TransactionId = TransactionID;
            detail.AlbumId = cart.AlbumId;
            detail.Qty = cart.Qty;

            return detail;
        }

    }
}