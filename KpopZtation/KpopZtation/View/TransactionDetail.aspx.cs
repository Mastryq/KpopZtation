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
    public partial class TransactionDetail : System.Web.UI.Page
    {

        public static List<KpopZtation.Model.TransactionDetail> transactions = new List<KpopZtation.Model.TransactionDetail>();

        protected void Page_Load(object sender, EventArgs e)
        {

            String transactionId = Request["transactionID"].ToString();

            transactionRepeater.DataSource = TransactionController.getTransactionById(transactionId);
            transactionRepeater.DataBind();

            //transactions = TransactionController.getTransactionById(transactionId);

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("TransactionPage.aspx");

        }
    }
}