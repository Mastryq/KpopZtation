using KpopZtation.Dataset;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["user"];

            if (cookie != null)
            {
                String role = cookie["Role"].ToString();

                if (!role.Equals("Admin"))
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }

            ModelKpopZtationEntities db = Connect.getInstances();

            TransactionReport report = new TransactionReport();

            CrystalReportViewer1.ReportSource = report;

            TransactionData data = getData(db.TransactionHeaders.ToList());

            report.SetDataSource(data);

        }

        private TransactionData getData(List<TransactionHeader> Transactions)
        {
            TransactionData data = new TransactionData();
            var table_header = data.TransactionHeader;
            var table_detail = data.TransactionDetail;

            foreach (TransactionHeader th in Transactions)
            {

                int grandTotal = 0;

                var Header_Row = table_header.NewRow();
                Header_Row["TransactionId"] = th.TransactionId;
                Header_Row["TransactionDate"] = th.TransactionDate.ToLongDateString();
                Header_Row["CustomerId"] = th.CustomerId;

                table_header.Rows.Add(Header_Row);

                foreach (KpopZtation.Model.TransactionDetail td in th.TransactionDetails)
                {
                    var Detail_Row = table_detail.NewRow();
                    Detail_Row["TransactionId"] = td.TransactionId;
                    Detail_Row["AlbumName"] = td.Album.AlbumName;
                    Detail_Row["Qty"] = td.Qty;
                    Detail_Row["AlbumPrice"] = td.Album.AlbumPrice;

                    int subTotal = td.Qty * td.Album.AlbumPrice;
                    Detail_Row["SubTotal"] = subTotal;

                    grandTotal += subTotal;

                    table_detail.Rows.Add(Detail_Row);
                }

                Header_Row["GrandTotal"] = grandTotal;

            }

            return data;

        }
    }
}