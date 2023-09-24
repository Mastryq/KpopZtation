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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            String email = emailBox.Text;
            String pass = passwordBox.Text;
            Boolean remember = rememberMe.Checked;

            String warningText = CustomerController.loginStatus(email, pass);
            warningLabel.Text = warningText;

            if (warningLabel.Text.Equals("Login Successfuly"))
            {
                Customer customer = CustomerController.getData(email, pass);

                HttpCookie cookie = new HttpCookie("user");
                cookie["Name"] = customer.CustomerName;
                cookie["Role"] = customer.CustomerRole;
                cookie["Email"] = customer.CustomerEmail;
                cookie["ID"] = customer.CustomerId.ToString();

                if (remember)
                {
                    cookie.Expires = DateTime.Now.AddMonths(1);
                }

                Response.Cookies.Add(cookie);
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}