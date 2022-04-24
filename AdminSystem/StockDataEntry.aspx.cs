using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        AnStock.phoneName = txtphoneName.Text;
        AnStock.Price = Convert.ToInt32(txtPrice.Text);
        AnStock.releaseDate = Convert.ToDateTime(txtreleaseDate.Text);
        AnStock.Availability = chkAvailability.Checked;
        AnStock.phoneColour = txtphoneColour.Text;

        Session["AnStock"] = AnStock;


        Response.Redirect("StockViewer.aspx");
    }

}