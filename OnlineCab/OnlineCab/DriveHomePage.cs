using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCab
{
    public partial class DriveHomePage : Form
    {
        int driverid = 0;
        static int totalmoney = 0;

        public DriveHomePage(string uname, string pwd,int driverid)
        {
            this.driverid = driverid;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentLocation = currentlocation.Text;

            Driver d = new Driver();
            d.AddCurrentLocation(Form1.uname,Form1.pwd,currentLocation);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cabs cab = new Cabs();
            cabrequestInformation.DataSource = cab.showCabRequest(driverid);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void CabrequestInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string messege = "Do you want to accept cab request for " + cabrequestInformation.Rows[e.RowIndex].Cells["source"].FormattedValue.ToString() + " to " + cabrequestInformation.Rows[e.RowIndex].Cells["destination"].FormattedValue.ToString() + " ?";
            string title = "Confirmation Window ";
            MessageBoxButtons messegeBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result =  MessageBox.Show(messege,title,messegeBoxButtons);
            Cabs cabs = new Cabs();

            if (result == DialogResult.Yes)
            {
                cabs.acceptCabRequest(Int32.Parse(cabrequestInformation.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString()));
            }
            else
            {
                cabs.cancleCabRequest(Int32.Parse(cabrequestInformation.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString()));
            }
        }

        private void AccpetedRequest_Click(object sender, EventArgs e)
        {
            Cabs cab = new Cabs();
            acceptedGridView.DataSource = cab.AllacceptedCabRequests(driverid);
        }

        private void AcceptedGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string messege = "Is Fair from " +acceptedGridView.Rows[e.RowIndex].Cells["source"].FormattedValue.ToString() + " to " +acceptedGridView.Rows[e.RowIndex].Cells["destination"].FormattedValue.ToString() + " completed ?";
            string title = "Confirmation Window ";
            MessageBoxButtons messegeBoxButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messege, title, messegeBoxButtons);
            Cabs cabs = new Cabs();

            totalmoney += Int32.Parse(acceptedGridView.Rows[e.RowIndex].Cells["fairamount"].FormattedValue.ToString());
            totalEarnings.Text =  "Total Earnings : " + totalmoney.ToString();

            if (result == DialogResult.Yes)
            {
                cabs.FairDone(Int32.Parse(acceptedGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString()));
            }
           

        }
    }
}
