using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySupplier();
        }
    }
    void DisplaySupplier()
    {
        clsSupplierCollection supplierCollection = new clsSupplierCollection(); 
        lstSupplierList.DataSource = supplierCollection.supplierList;
        lstSupplierList.DataValueField = "Supplier_Id";
        lstSupplierList.DataTextField = "sup_Name";
        lstSupplierList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Supplier_Id"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Supplier_Id; 
        if (lstSupplierList.SelectedIndex != 1 )
        {
            Supplier_Id = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["Supplier_Id"] = Supplier_Id;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "please select a record from list";
        }
    }
}