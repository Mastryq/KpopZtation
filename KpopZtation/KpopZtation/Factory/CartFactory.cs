using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Model;

namespace KpopZtation.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int CustomerID, int AlbumID, int Quantity)
        {
            Cart cart = new Cart();
            cart.CustomerId = CustomerID;
            cart.AlbumId = AlbumID;
            cart.Qty = Quantity;

            return cart;
        }
    }
}