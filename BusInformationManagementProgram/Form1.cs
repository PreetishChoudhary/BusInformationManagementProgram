using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusInformationManagementProgram
{
    public partial class MainForm : Form
    {
        class BusRecord
        {
            int busNumber;
            int arrivalTime;
            bool arrivalStatus;
            int averageArrivalTime;
            int arrivalDate;
        }

        void GetTime()
        {

        }

        public bool CheckStatus()
        {
            return true;
        }

        public void CreateEntry()
        {

        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            new CreateRecordForm().Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            new EditRecordForm().Show();
        }
    }
}
