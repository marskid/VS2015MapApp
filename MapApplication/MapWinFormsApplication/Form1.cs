using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapWinFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Loading...";
            ServiceReference.WebServiceSoapClient client = new ServiceReference.WebServiceSoapClient();
            entity1ViewModelBindingSourceShangHai.DataSource = client.GetDevicesByCity("上海");
            entity1ViewModelBindingSourceNanJing.DataSource = client.GetDevicesByCity("南京");
            this.Text = "Finish";
            client.Close();
        }
    }
}
