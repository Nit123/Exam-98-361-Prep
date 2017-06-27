using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Message from Page_Load. <br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Message from Page_Init. <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Message from Page_PreRender. <br/>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Message from Page_PreInit <br/>");
        }
    }
}