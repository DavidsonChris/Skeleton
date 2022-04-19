using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Supplier_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Supplier_Id = Convert.ToInt32(Session["Supplier_Id"]);
        if (IsPostBack == false)
        {
            if (Supplier_Id != -1) {
                DisplaySupplier();
            }
        }
    }
    void DisplaySupplier()
    {
        clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
        clsSupplierCollection.ThisSupplier.find(Supplier_Id);
        Supplier_ID.Text = clsSupplierCollection.ThisSupplier.supplier_id.ToString();
        supplierName.Text = clsSupplierCollection.ThisSupplier.Supplier_Name;
        Supplier_date.Text = clsSupplierCollection.ThisSupplier.DateAdded.ToString();
        Supplier_availibilty.Text = clsSupplierCollection.ThisSupplier.available.ToString();
        Supplier_phones.Text = clsSupplierCollection.ThisSupplier.Phones_Supplied;
        Supplier_contact.Text = clsSupplierCollection.ThisSupplier.Contact_Number;
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
            ASupplier.supplier_id = Supplier_Id;
            ASupplier.Supplier_Name = supName;
            ASupplier.DateAdded = Convert.ToDateTime(supDateTime);
            ASupplier.available = (int)Convert.ToInt64(supAvailbile);
            ASupplier.Phones_Supplied = supPhones;
            ASupplier.Contact_Number = supContact;

            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();

            if (Supplier_Id == -1)
            {
                clsSupplierCollection.ThisSupplier = ASupplier;
                clsSupplierCollection.Add();
            }
            else
            {
                clsSupplierCollection.ThisSupplier.find(Supplier_Id);
                clsSupplierCollection.ThisSupplier = ASupplier;
                clsSupplierCollection.update(); 

            }
            Response.Redirect("SupplierList.aspx");
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
            supplierName.Text = clssupplier.Supplier_Name;
            Supplier_date.Text = clssupplier.Sup_Start_Date.ToString();
            Supplier_availibilty.Text = clssupplier.available.ToString();
            Supplier_phones.Text = clssupplier.Phones_Supplied;
            Supplier_contact.Text = clssupplier.Contact_Number;
        }
    }
}