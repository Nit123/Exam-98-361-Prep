using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_2
{
    public partial class WebPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Any())
            {
                Request.QueryString.["Name"] = TextBox1.Text;
            }
            if (TextBox2.Text.Any())
            {
                Request.QueryString.Add = TextBox2.Text;
            }

            Response.Redirect("WebPage2.aspx");
        }
    }
}