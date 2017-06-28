using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_2
{
    public partial class WebPage2 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            string email = Request.QueryString["email"];
            Response.Write("<p>Thank you for confirming your information: </p> <br />");
            Response.Write("<p>Name: " + name + "</p> <br />");
            Response.Write("<p>Email: " + email + "</p> <br />");
        }
    }
}