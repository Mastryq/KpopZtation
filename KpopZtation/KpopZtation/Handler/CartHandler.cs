using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;

namespace KpopZtation.Handler
{
    public class CartHandler
    {
        public static void createCart(int CustomerID, int AlbumID, int Qty)
        {
            Cart cart = CartFactory.createCart(CustomerID, AlbumID, Qty);
            CartRepository.createCart(cart);
        }

        public static void deleteCartitem(String CustomerId, String AlbumId)
        {
            Cart cart = CartRepository.findCartbyAlbumID(CustomerId, AlbumId);
            CartRepository.deleteCartItem(cart);
        }

        public static void deleteCart(String CustomerId)
        {
            List<Cart> cart = CartRepository.getCartbyID(int.Parse(CustomerId));
            CartRepository.deleteCart(cart);
        }

        public static List<Cart> getCart(int id)
        {
            return CartRepository.getCartbyID(id);
        }

        public static void updateCart(Cart cart, int quantity)
        {
            CartRepository.updateCart(cart, quantity);
        }

    }
}