using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Description résumée de MyWebService
    /// </summary>
    [WebService(Namespace = "http://mc.org/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Message()
        {
            return "Hello MC!";
        }

        [WebMethod]
        public string[] Data() => new string[] { "Java", "C#", "Pyhton", "Javascript", "PHP" };

    }
}
