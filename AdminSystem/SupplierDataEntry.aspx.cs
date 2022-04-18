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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clssupplier ASupplier = new clssupplier();

        string supName = supplierName.Text;
        string supDateTime = Supplier_date.Text;
        string supAvailbile = Supplier_availibilty.Text;
        string supPhones = Supplier_phones.Text;
        string supContact = Supplier_contact.Text;

        string Error = "";
        Error = ASupplier.valid(supName, supDateTime, supAvailbile, supPhones, supContact);

        if (Error == "")
        {
            ASupplier.sup_Name = supName;
            ASupplier.DateAdded = Convert.ToDateTime(supDateTime);
            ASupplier.available = (int)Convert.ToInt64(supAvailbile);
            ASupplier.phones = supPhones;
            ASupplier.contact = supContact;
            Session["ASupplier"] = ASupplier;
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnFind_click(object sender, EventArgs e)
    {
        clssupplier clssupplier = new clssupplier();
        Int32 supplier_Id;
        Boolean found = false;
        supplier_Id = Convert.ToInt32(Supplier_ID.Text);
        found = clssupplier.find(supplier_Id);
        if (found == true)
        {
            supplierName.Text = clssupplier.sup_Name;
            Supplier_date.Text = clssupplier.Sup_Start_Date.ToString();
            Supplier_availibilty.Text = clssupplier.available.ToString();
            Supplier_phones.Text = clssupplier.phones;
            Supplier_contact.Text = clssupplier.contact;
        }
    }
}