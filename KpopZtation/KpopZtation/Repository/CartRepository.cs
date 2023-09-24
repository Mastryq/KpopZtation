using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class CartRepository
    {
        public static ModelKpopZtationEntities db = Connect.getInstances();
        public static void createCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static void deleteCartItem(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static Cart findCartbyID(String id)
        {
            int realId = int.Parse(id);
            return db.Carts.Find(realId);
        }

        public static Cart findCartbyAlbumID(String CustomerId, String AlbumId)
        {
            int realId = int.Parse(CustomerId);
            int realId2 = int.Parse(AlbumId);
            return (from x in db.Carts where x.CustomerId == realId && x.AlbumId == realId2 select x).FirstOrDefault();
        }

        public static List<Cart> getCartbyID(int id)
        {
            return (from x in db.Carts where x.CustomerId == id select x).ToList();
        }

        public static void updateCart(Cart cart, int quantity)
        {
            cart.Qty = cart.Qty + quantity;
            db.SaveChanges();
        }

        public static void deleteCart(List<Cart> cart)
        {
            foreach (var x in cart)
            {
                db.Carts.Remove(x);
            }
            db.SaveChanges();
        }
    }
}