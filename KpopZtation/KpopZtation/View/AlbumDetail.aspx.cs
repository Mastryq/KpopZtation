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
    public partial class AlbumDetail : System.Web.UI.Page
    {
        private bool isAdmin = false;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];

                if (cookie != null)
                {
                    String role = cookie["Role"].ToString();

                    if (role == "User")
                    {
                        isAdmin = true;
                        QuantityBox.Visible = true;
                        QuantityLabel.Visible = true;
                        WarningLabel.Visible = true;
                        AddToCartButton.Visible = true;
                        OrderLabel.Visible = true;
                    }
                }

            }

            String albumId = Request["AlbumId"];

            Album album = AlbumController.getAlbumById(albumId);

            AlbumNameText.Text = album.AlbumName;
            AlbumImage.ImageUrl = album.AlbumImage;
            AlbumDesText.Text = album.AlbumDescription;
            AlbumStockText.Text = album.AlbumStock.ToString();
            AlbumPriceText.Text = album.AlbumPrice.ToString();

        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["user"];

            String customerID = cookie["ID"];
            int albumID = int.Parse(Request.QueryString["AlbumID"]);
            String quantity = QuantityBox.Text;

            String warningText = CartController.createCart(int.Parse(customerID), albumID, quantity);
            WarningLabel.Text = warningText;

        }
    }
}