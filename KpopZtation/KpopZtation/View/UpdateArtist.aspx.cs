using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        private static Artist artistBefore;
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

                String id = Request["ArtistId"];
                artistBefore = ArtistController.getArtist(id);

                artistImage.ImageUrl = artistBefore.ArtistImage;
                artistName.Text = artistBefore.ArtistName;
                artistNameBox.Text = artistBefore.ArtistName;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            String name = artistNameBox.Text;
            HttpPostedFile postedFile = imageUpload.PostedFile;
            String id = Request["ArtistId"];

            String warningText = ArtistController.updateArtist(name, postedFile, id);
            warningLabel.Text = warningText;

            if (warningLabel.Text.Equals("Insert Successfuly !"))
            {
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}