using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        private static Album albumBeforeUpdate;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];

                if (cookie != null)
                {
                    String role = cookie["Role"].ToString();

                    if (!role.Equals("Admin"))
                    {
                        Response.Redirect("HomePage.aspx");
                    }
                } else
                {
                    Response.Redirect("HomePage.aspx");
                }

                String albumId = Request["AlbumId"];
                albumBeforeUpdate = AlbumController.getAlbumById(albumId);

                albumNameBox.Text = albumBeforeUpdate.AlbumName;
                albumDescriptionBox.Text = albumBeforeUpdate.AlbumDescription;
                albumPriceBox.Text = albumBeforeUpdate.AlbumPrice.ToString();
                albumStockBox.Text = albumBeforeUpdate.AlbumStock.ToString();
                albumImage.ImageUrl = albumBeforeUpdate.AlbumImage;
            }
        }

        protected void albumUpdateButton_Click(object sender, EventArgs e)
        {
            String albumId = Request["AlbumId"];
            String albumName = albumNameBox.Text;
            String albumDescription = albumDescriptionBox.Text;
            String albumPrice = albumPriceBox.Text;
            String albumStock = albumStockBox.Text;

            HttpPostedFile albumImage = albumImageUpload.PostedFile;

            String warningText = AlbumController.updateAlbum(albumBeforeUpdate, albumId, albumName, albumDescription, albumPrice, albumStock, albumImage);
            warningLabel.Text = warningText;

            if (warningLabel.Text.Equals("Update Success!"))
            {
                Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + albumBeforeUpdate.ArtistId);
            }
        }
    }
}