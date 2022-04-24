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
            clsStock AnStock = new clsStock();
            AnStock = (clsStock)Session["AnStock"];
            Response.Write(AnStock.phoneName);
            Response.Write(AnStock.Price);
            Response.Write(AnStock.releaseDate);
            Response.Write(AnStock.Availability);
            Response.Write(AnStock.phoneColour);


    }
  
    


}