using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_4
{
    public partial class SubmittedForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"] != null && Session["Email"] != null)
            {
                Label1.Text = String.Format("Welcome {0}.", Session["Name"]);
                Label2.Text = String.Format("The submitted email was {0}.", Session["Email"]);
            }
            else
                Response.Redirect("GetterForm.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("Name");
            Session.Remove("Email");
            Response.Redirect("GetterForm.aspx");
        }
    }
}