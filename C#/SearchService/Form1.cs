using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CookComputing.XmlRpc;
using System.Net;
using System.IO;
using System.Xml;

namespace SearchService
{

    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();

            String path = "OrgTypes";
            String type = "type";
            getData(path,cbxOrgType,type);
            cbxOrgType.Items.Insert(0, "-All Org Types-");
            cbxOrgType.SelectedIndex = 0;

            cbxState.Items.Insert(0, "-All States-");
            cbxState.SelectedIndex = 0;

            /*
            path = "States";
            type = "State";
            getData(path, cbxState, type);*/
        }

        private void getData(String path,ComboBox output,String type)
        {
            pgrBar.Style = ProgressBarStyle.Marquee;
            pgrBar.MarqueeAnimationSpeed = 30;

            String uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/";
            uri = uri + path;

            //Connect to web request
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);

            //Indicate that it is read only
            req.Method = "GET";
            try{
                //get and Store the response and convert into a usable stream
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream str = res.GetResponseStream();

                //Read stream as xml
                XmlReader xr = XmlReader.Create(str);

                //Clear the combo box
                //output.Text = "--Select--";
                output.Items.Clear();
                //output.Text = "All " + path;
                //output.SelectedIndex = 1;


                //output.SelectedItem = "-SELECT OPERATIONS-";

                //Add Org Types to combobox
                while (xr.Read())
                {
                    if (xr.Name != "")
                    {
                        xr.ReadToFollowing(type);
                        output.Items.Add(xr.ReadElementContentAsString());
                    }
                }


                //Close connection to the resource
                res.Close();
            }
            catch
            {
                Console.Write("Error1");
            }

            pgrBar.Style = ProgressBarStyle.Continuous;
            pgrBar.MarqueeAnimationSpeed = 0;
        }



        private void btnResults_Click(object sender, EventArgs e)
        {
            pgrBar.Style = ProgressBarStyle.Marquee;
            pgrBar.MarqueeAnimationSpeed = 30;

            //FrmResults results = new FrmResults();
            //results.ShowDialog();

            //Clear the grid
            dgvResults.Rows.Clear();

            String uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/Organizations?";

            //Add parameters for search form:
            if (cbxOrgType.Text != "-All Org Types-")
            {
                uri = uri + "&type=" + cbxOrgType.Text;
            }
            if (txtOrgName.Text != "")
            {
                uri = uri + "&name=" + txtOrgName.Text;
            }
            if (cbxState.Text != "" & cbxState.Text != "-All States-")
            {
                uri = uri + "&state=" + cbxState.Text;
            }
            if (cbxCity.Text != "" & cbxCity.Text != "-All Cities-")
            {
                uri = uri + "&town=" + cbxCity.Text;
            }
            if (txtCounty.Text != "")
            {
                uri = uri + "&county=" + txtCounty.Text;
            }
            if (txtZip.Text != "")
            {
                uri = uri + "&zip=" + txtZip.Text;
            }

            //Console.Write(uri);

            //Connect to web request
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
        
            //Indicate that it is read only
            req.Method = "GET";
            try
            {
                //get and Store the response and convert into a usable stream
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream str = res.GetResponseStream();

                //Read stream as xml
                XmlReader xr = XmlReader.Create(str);

                //Fill the grid
                int row = 0;
                int col = 0;
                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "data")
                    {
                        row = dgvResults.Rows.Add();
                        col = 0;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        dgvResults.Rows[row].Cells[col].Value = xr.Value;
                        col++;
                    }
                }
            }
            catch
            {
                Console.Write("Error2");
            }

            pgrBar.Style = ProgressBarStyle.Continuous;
            pgrBar.MarqueeAnimationSpeed = 0;
        }

        private void cbxState_SelectedValueChanged(object sender, EventArgs e)
        {
            String state = cbxState.Text;
            String path = "Cities?state=" + state;
            String type = "city";
            getData(path, cbxCity, type);
            cbxCity.Items.Insert(0, "-All Cities-");
            cbxCity.SelectedIndex = 0;   
            //Console.WriteLine("works");
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            int Orgid = Convert.ToInt32(dgvResults[0, row].Value);

            String id = Orgid.ToString();
            FrmResults resultsForm = new FrmResults(id);
            resultsForm.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxOrgType.SelectedIndex = 0;
            cbxState.SelectedIndex = 0;

            txtOrgName.Clear();
            txtCounty.Clear();
            txtZip.Clear();
        }
    }
}
