using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Supplier_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Supplier_Id = Convert.ToInt32(Session["Supplier_Id"]);
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
        clsSupplierCollection.ThisSupplier.find(Supplier_Id);
        clsSupplierCollection.Delete();
        Response.Redirect("SupplierList.aspx");
    }
}