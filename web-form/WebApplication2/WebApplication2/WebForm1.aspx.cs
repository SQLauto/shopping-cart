using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "Welcome to Data Management\nSelect category:";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(DropDownList1.SelectedValue);
            
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

    
    }
}