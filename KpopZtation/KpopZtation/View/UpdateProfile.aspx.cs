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
    public partial class UpdateProfile : System.Web.UI.Page
    {

        private static Customer customerBeforeUpdate;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];

                if(cookie != null)
                {
                    String role = cookie["Role"].ToString();
                    String email = cookie["Email"];

                    customerBeforeUpdate = CustomerController.getDataByEmail(email);

                    nameBox.Text = customerBeforeUpdate.CustomerName;
                    emailBox.Text = customerBeforeUpdate.CustomerEmail;
                    genderCheck.SelectedValue = customerBeforeUpdate.CustomerGender;
                    addressBox.Text = customerBeforeUpdate.CustomerAddress;
                    passwordBox.Text = customerBeforeUpdate.CustomerPassword;
                } else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
        }

        protected void updateProfileButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String email = emailBox.Text;
            String gender = genderCheck.SelectedValue.ToString();
            String address = addressBox.Text;
            String password = passwordBox.Text;

            String warningText = CustomerController.updateCustomer(customerBeforeUpdate, name, email, gender, address, password);
            warningLabel.Text = warningText;

            if (warningText == "Update Successful")
            {
                HttpCookie cookie = Request.Cookies["user"];

                if (cookie != null)
                {
                    cookie["Name"] = name;
                    cookie["Email"] = email;

                    Response.Cookies.Add(cookie);
                }
            }
        }

        protected void deleteAccountButton_Click(object sender, EventArgs e)
        {
            bool confirmDeletion = deletionCheckBox.Checked;

            if (confirmDeletion)
            {
                TransactionController.deleteTransactionHeaderbyCustomerId(customerBeforeUpdate.CustomerId.ToString());
                CustomerController.deleteCustomer(customerBeforeUpdate);

                HttpCookie cookie = Request.Cookies["user"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Set(cookie);

                Response.Redirect("~/View/LoginPage.aspx");
            } else
            {
                deletionLabel.Text = "Checkbox must be checked!";
            }

        }
    }
}