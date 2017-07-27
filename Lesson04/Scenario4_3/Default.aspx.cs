﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var webService = new textWebService.TextWebServiceSoapClient();
           // webService.ToLowerAsync(TextBox1.Text);
            toLowerLabel.Text = webService.ToLower(TextBox1.Text);
           toUpperLabel.Text = webService.ToUpper(TextBox1.Text);
        }
    }
}