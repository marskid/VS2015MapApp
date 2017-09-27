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
            textBox1.Text = "Loading..." + System.Console.Out.NewLine;
            ServiceReference.WebServiceSoapClient client = new ServiceReference.WebServiceSoapClient();
            entity1ViewModelBindingSourceShangHai.DataSource = client.GetDevicesByCity("上海");
            entity1ViewModelBindingSourceNanJing.DataSource = client.GetDevicesByCity("南京");
            client.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text += "Binding Brower Message..." + System.Console.Out.NewLine;
            var message = webBrowser1.Document.Body.GetElementsByTagName("textarea").GetElementsByName("message");
            foreach (HtmlElement element in message)
            {
                element.AttachEventHandler("onpropertychange", (s, args) =>
                {
                    textBox1.Text = element.InnerText;
                    textBox1.SelectionStart = textBox1.Text.Length - 1;
                    textBox1.ScrollToCaret();

                });
            }
            textBox1.Text += "Binded" + System.Console.Out.NewLine;
            textBox1.SelectionStart = textBox1.Text.Length - 1;
            textBox1.ScrollToCaret();

            dataGridView1.CellEnter += this.dataGridView1_CellEnter;
            dataGridView3.CellEnter += this.dataGridView3_CellEnter;

            textBox1.Text += "Finish" + System.Console.Out.NewLine;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var longitude = dataGridView1.CurrentRow.Cells[2].Value;
            var latitude = dataGridView1.CurrentRow.Cells[3].Value;
            webBrowser1.Document.InvokeScript("moveToMarker", new object[] { longitude, latitude });
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var longitude = dataGridView3.CurrentRow.Cells[2].Value;
            var latitude = dataGridView3.CurrentRow.Cells[3].Value;
            webBrowser1.Document.InvokeScript("moveToMarker", new object[] { longitude, latitude });

        }
    }
}
