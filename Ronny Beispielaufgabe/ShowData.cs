using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Ronny_Beispielaufgabe
{
    public partial class ShowData : Form
    {

        #region Variables

        private DataTable dtMain = new DataTable();

        #endregion

        public ShowData()
        {
            InitializeComponent();
            setTranslations();
            getInitialData();
        }

        #region Translations
        private void setTranslations()
        {
            btnShowData.Text = "Datenanzeige";
        }

        #endregion

        #region Get Initial Data

        private void getInitialData()
        {
            try
            {
                //Webrequest + Response Reader to String
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://my-json-server.typicode.com/typicode/demo/posts");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string result = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //Json Result to Datatable
                dtMain = JsonConvert.DeserializeObject<DataTable>(result);

                //Debug info
                Console.WriteLine($"{result}\n");
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        #endregion

        #region Buttons Clicks
        private void btnShowData_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for Data
                if(dtMain != null && dtMain.Rows.Count > 0)
                {
                    //Show Data
                    dgvMainData.Visible = Visible;
                    dgvMainData.DataSource = dtMain;

                    //Reset Errorinfo
                    label1.Text = "Hier werden Daten in einem Gridview dargestellt";
                    label1.ForeColor = Color.Black;
                }
                else
                {
                    //Show Errorinfo
                    label1.Text = "Keine Daten Gefunden!";
                    label1.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        #endregion

    }
}
