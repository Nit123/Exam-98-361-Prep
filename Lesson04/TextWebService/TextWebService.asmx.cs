using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TextWebService
{
    /// <summary>
    /// Summary description for TextWebService
    /// </summary>
    [WebService(Namespace = "http://northwindtraders.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TextWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ToUpper(string inputString)
        {
            return inputString.ToUpper();
        }

        [WebMethod]
        public string ToLower(string inputString)
        {
            return inputString.ToLower();
        }
    }
}
