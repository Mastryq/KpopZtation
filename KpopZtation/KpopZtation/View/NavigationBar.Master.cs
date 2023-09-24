using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class NavigationBar : System.Web.UI.MasterPage
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
                        cartButton.Visible = false;
                        loginButton.Visible = false;
                        registerButton.Visible = false;
                        viewProfileButton.Visible = false;
                    }
                    else if (role.Equals("User"))
                    {
                        loginButton.Visible = false;
                        registerButton.Visible = false;
                    }
                }
                else
                {
                    cartButton.Visible = false;
                    transactionButton.Visible = false;
                    updateProfileButton.Visible = false;
                    logoutButton.Visible = false;
                    viewProfileButton.Visible = false;
                }
            }

        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void cartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }

        protected void transactionButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            String role = cookie["Role"].ToString();
            if (role.Equals("Admin"))
            {
                Response.Redirect("TransactionReportPage.aspx");
            }
            else if (role.Equals("User"))
            {
                Response.Redirect("TransactionPage.aspx");
            }
        }

        protected void updateProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfile.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];

            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Set(cookie);
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void viewProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfilePage.aspx");
        }

    }
}