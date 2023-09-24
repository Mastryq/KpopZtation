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
    public partial class ViewProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["user"];

            if (cookie != null)
            {

                String role = cookie["Role"].ToString();
                if (role.Equals("Admin"))
                {
                    Response.Redirect("HomePage.aspx");
                }

                String customerID = cookie["ID"];
                Customer customer = CustomerController.getDataById(int.Parse(customerID));

                UserNameText.Text = customer.CustomerName;
                UserEmailText.Text = customer.CustomerEmail;
                UserGenderText.Text = customer.CustomerGender;
                UserAddressText.Text = customer.CustomerAddress;
                UserRoleText.Text = customer.CustomerRole;
            
            } else
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }
    }
}