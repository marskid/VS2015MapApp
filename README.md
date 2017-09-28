# VS2015MapApp

![BaiduMapWinForm](https://raw.githubusercontent.com/marskid/marskid.github.io/master/2017/09/BaiduMapWinForm2.gif)

## Structure

```
              [Web Server]
              /          \
        Map Page        Web Service
          |              /
          |    Service Reference
          |     /        /  
        Web Browser    /
                \    /
                WinForm
```

## [Web Service](https://docs.microsoft.com/en-us/dotnet/framework/wcf/samples/interoperating-with-asmx-web-services)

* [WebService.asmx](https://github.com/marskid/VS2015MapApp/blob/master/MapApplication/WebApplication/WebService.asmx.cs)

```
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
```

* [ASP.NET Service Reference](https://github.com/marskid/VS2015MapApp/blob/master/MapApplication/WebApplication/Index.aspx)

```
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/main.js" />
            </Scripts>
            <Services>
                <asp:ServiceReference Path="~/WebService.asmx" />
            </Services>
        </asp:ScriptManager>
    </form>
```

Call Web Service from Web Browser using JavaScript. [main.js](https://github.com/marskid/VS2015MapApp/blob/master/MapApplication/WebApplication/Scripts/main.js)
```
WebApplication.WebService.GetDevices(onSuccess, onError);
```

* [WinForm Service Reference](https://github.com/marskid/VS2015MapApp/blob/master/MapApplication/MapWinFormsApplication/Form1.cs)

```
    private void Form1_Load(object sender, EventArgs e)
    {
        textBox1.Text = "Loading..." + System.Console.Out.NewLine;
        ServiceReference.WebServiceSoapClient client = new ServiceReference.WebServiceSoapClient();
        entity1ViewModelBindingSourceShangHai.DataSource = client.GetDevicesByCity("上海");
        entity1ViewModelBindingSourceNanJing.DataSource = client.GetDevicesByCity("南京");
        client.Close();
    }
```

## [Using Web Browser in WinForm](https://github.com/marskid/VS2015MapApp/blob/master/MapApplication/MapWinFormsApplication/Form1.cs)

* [InvokeScript](https://msdn.microsoft.com/en-us/library/cc491132(v=vs.110).aspx)

```
    private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        var longitude = dataGridView1.CurrentRow.Cells[2].Value;
        var latitude = dataGridView1.CurrentRow.Cells[3].Value;
        webBrowser1.Document.InvokeScript("moveToMarker", new object[] { longitude, latitude });
    }
```
* [AttachEventHandler](https://msdn.microsoft.com/en-us/library/system.windows.forms.htmldocument.attacheventhandler(v=vs.110).aspx)

```
    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        foreach (HtmlElement element in message)
        {
            element.AttachEventHandler("onpropertychange", (s, args) =>
            {
                textBox1.Text = element.InnerText;
                textBox1.SelectionStart = textBox1.Text.Length - 1;
                textBox1.ScrollToCaret();

            });
        }
    }
```
