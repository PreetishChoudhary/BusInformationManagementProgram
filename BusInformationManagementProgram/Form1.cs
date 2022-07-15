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
            if (type == "school")
            {
                type = "SchoolBuses/";
            }
            else
            {
                type = "SportBuses/";
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(type + "BusData_" + busNumber + ".xml");

            XmlNodeList xmlBusRecord = doc.GetElementsByTagName("BusData");

            busRecord = new BusRecord[xmlBusRecord.Count];

            int index = 0;
            foreach (XmlNode busData in xmlBusRecord)
            {
                int arrivalDate = Convert.ToInt32(busData.Attributes["date"].Value);
                BusRecord b = new BusRecord();
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

        public void DisplayData(int busIndex)
        {
            for(int i = busRecordArray[busIndex].Length -1; i>-1; i--) {
                BusRecord b = busRecordArray[busIndex][i];
                string status;
                try
                {
                    if (b.atSchool == true)
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
                catch
                {
                    
                }
            }
        }

        void FillComboBox(string filePath)
        {
            string[] fileText = System.IO.File.ReadAllLines(filePath);
            foreach (string line in fileText)
            {
                cmbBxBuses.Items.Add(line);
            }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        BusRecord[] busRecord;
        List<BusRecord[]> busRecordArray = new List<BusRecord[]>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillComboBox("BusList.txt");

            for (int i = 1; i < 22; i++)
            {
                ReadFile(i, "school");
                busRecordArray.Add(busRecord);
            }
        }

        private void cmbBxBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData(Convert.ToInt32(cmbBxBuses.SelectedIndex.ToString()));
        }
    }
}
