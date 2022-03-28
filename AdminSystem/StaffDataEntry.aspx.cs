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
        //Fixing
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //Capture the staff id
        AnStaff.Staff_fullname = txtStaff_fullname.Text;
        AnStaff.Email_Address = txtEmail_address.Text;
        AnStaff.Staff_department = txtStaff_department.Text;
        AnStaff.Staff_DOB = Convert.ToDateTime( txtStaff_DOB);
        AnStaff.Availability = Convert.ToBoolean(chkAvailability.Checked);
        //Store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key
        Int32 Staff_id;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Staff_id =Convert.ToInt32(txtStaff_id.Text);
        //find the record
        Found = AnStaff.Find(Staff_id);
        //if found
        if (Found == true)
        {
            txtStaff_fullname.Text = AnStaff.Staff_fullname;
            txtStaff_department.Text = AnStaff.Staff_department;
            txtStaff_DOB.Text = AnStaff.Staff_DOB.ToString();
            txtEmail_address.Text = AnStaff.Email_Address.ToString();
            chkAvailability.Checked = AnStaff.Availability;
        }
}
}
