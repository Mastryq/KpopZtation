using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];

                if(cookie != null)
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
            }
        }

        protected void albumInsertButton_Click(object sender, EventArgs e)
        {
            String artistId = Request["ArtistId"];
            String albumName = albumNameBox.Text;
            String albumDescription = albumDescriptionBox.Text;
            String albumPrice = albumPriceBox.Text;
            String albumStock = albumStockBox.Text;

            HttpPostedFile albumImage = albumImageUpload.PostedFile;

            String warningText = AlbumController.createAlbum(artistId, albumName, albumDescription, albumPrice, albumStock, albumImage);
            warningLabel.Text = warningText;

            if (warningLabel.Text.Equals("Insert Successful!"))
            {
                Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + artistId);
            }
        }
    }
}