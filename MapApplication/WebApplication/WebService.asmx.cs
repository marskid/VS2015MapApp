using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DALClassLibrary.DAL;
using DALClassLibrary.Models;
using WebApplication.Models;

namespace WebApplication
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        DeviceOperator E1 = new DeviceOperator();
        [WebMethod]
        public Entity1ViewModel HelloWorld()
        {
            var entity = E1.Add("ppp1", "ppp2", "ppp3", "上海", "12");
            return new Entity1ViewModel(entity);
        }
    }
}
