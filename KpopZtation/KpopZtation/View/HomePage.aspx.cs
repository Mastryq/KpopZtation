using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected bool isAdmin = false;

        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                String role = cookie["Role"].ToString();

                if (role.Equals("Admin"))
                {
                    isAdmin = true;
                    insertButton.Visible = true;
                } 
            }

            artistRepeater.DataSource = ArtistController.getAllArtist();
            artistRepeater.DataBind();
        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertArtist.aspx");
        }

        protected void updateButton_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/View/UpdateArtist.aspx?ArtistId=" + e.CommandArgument.ToString());
        }

        protected void deleteButton_Command(object sender, CommandEventArgs e)
        {
            TransactionController.deleteTransactionDetailbyArtistId(e.CommandArgument.ToString());
            AlbumController.deleteAllAlbum(e.CommandArgument.ToString());
            ArtistController.deleteArtist(e.CommandArgument.ToString());
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void selectButton_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + e.CommandArgument.ToString());
        }
    }
}