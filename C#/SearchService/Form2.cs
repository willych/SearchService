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
using System.Xml;

namespace SearchService
{
    public partial class FrmResults : Form
    {
        public FrmResults(String OrgId)
        {
            InitializeComponent();
            Console.Write(OrgId);

            resetTabs();
            getGeneral(OrgId);
            getLocation(OrgId);
            getTreatment(OrgId);
            getTraining(OrgId);
            getFacil(OrgId);
            getPhys(OrgId);
            getPeople(OrgId);

        }
        private void removeTab(TabPage page)
        {
            tabs.TabPages.Remove(page);
            //tabs.TabPages.Insert(0, tabPage1);//Insert after the 0th one
        }

        private void getData(String path, Object output, String type)
        {
            String uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/";
            uri = uri + path;

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

                if (type == "txt")
                {
                    Label lbl = (Label)output;
                    //Add to txt
                    while (xr.Read())
                    {
                        if (xr.Name != "")
                        {
                            xr.ReadToFollowing(type);
                            lbl.Text = xr.ReadElementContentAsString();
                        }
                    }
                }

                else if (type == "grid")
                {
                    DataGridView grid = (DataGridView)output;
                    //Fill the grid
                    int row = 0;
                    int col = 0;
                    while (xr.Read())
                    {
                        if (xr.NodeType == XmlNodeType.Element && xr.Name == "data")
                        {
                            row = grid.Rows.Add();
                            col = 0;
                        }
                        else if (xr.NodeType == XmlNodeType.Text)
                        {
                            grid.Rows[row].Cells[col].Value = xr.Value;
                            col++;
                        }
                    }
                }

                //Close connection to the resource
                res.Close();
            }
            catch
            {
                Console.Write("Error");
            }
        }

        private void resetTabs()
        {

        }

        private void getLocation(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/Locations";
            String type = "txt";
            getData(path,lblLoc, type);
        }

        private void getGeneral(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/General";
            String type = "txt";
            getData(path,lblGeneral, type);
        }

        private void getTreatment(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/Treatment";
            String type = "grid";
            getData(path,dgvTreat,type);
        }

        private void getTraining(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/Training";
            String type = "grid";
            getData(path, dgvTrain, type);
        }

        private void getFacil(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/Facilities";
            String type = "grid";
            getData(path, dgvFacil, type);
        }

        private void getPhys(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/Physicians";
            String type = "grid";
            getData(path, dgvPhys, type);
        }

        private void getPeople(String OrgId)
        {
            //Builds data for getData method
            String path = OrgId + "/People";
            String type = "grid";
            getData(path, dgvPeople, type);
        }

    }
}
