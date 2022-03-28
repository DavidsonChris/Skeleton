using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //Get the data from the seesion object
        AnStaff = (clsStaff)Session["AnStaff"];
        //Dislay the full name of this entry
        Response.Write(AnStaff.Staff_fullname);
        Response.Write(AnStaff.Staff_department);
        Response.Write(AnStaff.Email_Address);
        Response.Write(AnStaff.Availability);
        Response.Write(AnStaff.Staff_DOB);
        Response.Write(AnStaff.Staff_id);


    }
}