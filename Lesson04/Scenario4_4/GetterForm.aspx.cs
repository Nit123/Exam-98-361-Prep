using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_4
{
    public partial class GetterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Email"] != null)
                Response.Redirect("SubmittedForm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("Name", TextBox1.Text);
            Session.Add("Email", TextBox2.Text);
            Response.Redirect("SubmittedForm.aspx");
        }
    }
}