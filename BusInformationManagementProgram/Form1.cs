using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BusInformationManagementProgram
{
    public partial class MainForm : Form
    {
        class BusRecord
        {
            public int busNumber;
            public int arrivalDate;
            public int arrivalTime;
            public int departTime;
            public bool atSchool;
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

        public string dateTimeFormat(int dateTime, string type)
        {
            if(type == "date")
            {
                string date = Convert.ToString(dateTime);
                date.Insert(date.Length - 2, ":");
                return date;

            }
            else
            {
                string time = Convert.ToString(dateTime);
                time.Insert(time.Length - 2, ":");
                return time;
            }
        }

        public void ReadFile(int busNumber, string type)
        {
            if(type == "school")
            {
                type = "SchoolBuses/";
            }
            else
            {
                type = "SportBuses/";
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(type +"BusData_"+busNumber+".xml");

            XmlNodeList xmlBusRecord = doc.GetElementsByTagName("BusData");

            busRecord = new BusRecord[xmlBusRecord.Count];

            int index = 0;
            foreach (XmlNode busData in xmlBusRecord)
            {
                BusRecord b = new BusRecord();
                int arrivalDate = Convert.ToInt32(busData.Attributes["date"].Value);
                int arrivalTime = Convert.ToInt32(busData["arrivalTime"].InnerText);
                int departTime = Convert.ToInt32(busData["departureTime"].InnerText);
                bool status = Convert.ToBoolean(busData["atSchool"].InnerText);

                b.busNumber = busNumber;
                b.arrivalDate = arrivalDate;
                b.arrivalTime = arrivalTime;
                b.departTime = departTime;
                b.atSchool = status;

                busRecord[index] = b;
                index++;
            }
        }

        public void DisplayData()
        {
            BusRecord b = busRecord[0];
            string status;
            if(b.atSchool == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            string[] data = { b.busNumber.ToString(), status, dateTimeFormat(b.arrivalTime, "time"), dateTimeFormat(b.departTime, "time"), dateTimeFormat(b.arrivalDate, "date") };
            dataGridView1.Rows.Add(data);
        }


        public MainForm()
        {
            InitializeComponent();
        }

        BusRecord[] busRecord;
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadFile(18, "school");
            DisplayData();
        }
    }
}
