using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String email = emailBox.Text;
            String gender = genderCheck.SelectedValue.ToString();
            String address = addressBox.Text;
            String pass = passwordBox.Text;

            String warningText = CustomerController.createCustomer(name, email, gender, address, pass);
            warningBox.Text = warningText;
            if (warningBox.Text.Equals("Register Successful"))
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}