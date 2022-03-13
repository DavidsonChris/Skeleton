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
        //Create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //Capture the staff id
        AnStaff.Staff_fullname = txtStaff_fullname.Text;
        AnStaff.Email_Address = txtEmail_Address.Text;
        AnStaff.Staff_department = txtStaff_department.Text;
        //Store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}