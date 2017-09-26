using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DALClassLibrary;
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
        private DeviceOperator Device;
        private CityOperator City;

        public WebService()
        {
            Device = new DeviceOperator();
            City = new CityOperator();
        }

        [WebMethod]
        public Entity1ViewModel HelloWorld()
        {
            return new Entity1ViewModel() {
                Id = 1,
                name = "P1",
                longitude = "31.294247596015893",
                latitude = "121.37798305482751",
                Entity2 = new Entity2ViewModel() {
                    Id = 1,
                    name = "上海",
                    zoom = "12"
                }
            };
        }

        [WebMethod]
        public Entity1ViewModel AddDevice(string deviceName, string longitude, string latitude, string cityName, string zoomLevel)
        {
            var entity = Device.Add(deviceName, longitude, latitude, cityName, zoomLevel);

            return new Entity1ViewModel(entity);
        }

        [WebMethod]
        public List<Entity1ViewModel> GetDevices()
        {
            return Device.GetAll().Select(s => new Entity1ViewModel(s)).ToList();
        }

        [WebMethod]
        public List<Entity2ViewModel> GetCities()
        {
            return City.GetAll().Select(s => new Entity2ViewModel(s)).ToList();
        }

        [WebMethod]
        public List<Entity1ViewModel> GetDevicesByCity(string city)
        {
            return Device.Get(city).Select(s => new Entity1ViewModel(s)).ToList();
        }
    }
}
