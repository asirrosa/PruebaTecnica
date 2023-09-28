using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            listView1.Clear();
            listView1.Columns.Add("NOTAS:",800);
            var nodeApiData = this.getNodeApiData();
            if(nodeApiData != null )
            {
                foreach(var nodeApi in nodeApiData.data)
                {
                    ListViewItem listItem = new ListViewItem("Nota " + nodeApi +": Esta es la nota: " + nodeApi );
                    this.listView1.Items.Add(listItem);
                }
            }
        }

        public NodeApi getNodeApiData()
        {
            string url = "http://localhost:1337/notas";
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                string jsonString = string.Empty;
                using(System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    jsonString = reader.ReadToEnd();
                }
                NodeApi notas = JsonConvert.DeserializeObject<NodeApi>(jsonString);
                if (notas == null | notas.data == null)
                {
                    return null;
                }
                else
                {
                    return notas;
                }


            }catch (WebException ex)
            {
                Console.WriteLine("Servicio no disponible. Inténtelo más tarde");
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public void GetWebRequest(string method, HttpWebRequest request)
        {
            try
            {
                var pdata = txtBox.Text;
                var data = Encoding.ASCII.GetBytes(pdata);
                request.Method = method;
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Servicio no disponible. Inténtelo más tarde");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show("Por favor introduce un valor para la nota");
                return;
            }
            else
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:1337/notas?" + txtBox.Text);
                this.GetWebRequest("POST",request);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            fillData();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:1337/notas");
            this.GetWebRequest("DELETE",request);
        }
    }
}
