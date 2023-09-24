using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Controller;
using KpopZtation.Model;

namespace KpopZtation.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                HttpCookie cookie = Request.Cookies["user"];

                if (cookie != null)
                {
                    String role = cookie["Role"].ToString();

                    if (role.Equals("Admin"))
                    {
                        Response.Redirect("HomePage.aspx");
                    }
                } else
                {
                    Response.Redirect("HomePage.aspx");
                }

                String customerId = cookie["ID"];
                List<Cart> cart = CartController.getCart(int.Parse(customerId));

                WarningLabel.Text = CartController.CartisEmpty(int.Parse(customerId));

                if (WarningLabel.Text != "Cart is Empty !")
                {
                    CheckoutButton.Visible = true;
                }
                else
                {
                    CheckoutButton.Visible = false;
                }

                albumRepeater.DataSource = cart;
                albumRepeater.DataBind();
            }

        }

        protected void deleteButton_Command(object sender, CommandEventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];

            String customerId = cookie["ID"];
            CartController.deleteCartItem(customerId, e.CommandArgument.ToString());

            String url = "CartPage.aspx?customerId=" + customerId;
            Response.Redirect(url);
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            String customerId = cookie["ID"];

            String TransactionId = TransactionController.createHeader(int.Parse(customerId));

            List<Cart> cart = CartController.getCart(int.Parse(customerId));

            TransactionController.createDetails(int.Parse(TransactionId), cart);

            CartController.deleteCart(customerId);

            String url = "HomePage.aspx";
            Response.Redirect(url);
        }
    }
}