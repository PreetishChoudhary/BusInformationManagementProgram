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

        public string DateTimeFormat(int dateTime, string type)
        {
            if (dateTime != 0)
            {
                if (type == "date")
                {
                    string date = Convert.ToString(dateTime);
                    string formattedDate = date.Substring(0, date.Length - 4) + "/" + date.Substring(date.Length - 4, date.Length - 4) + "/" + date.Substring(date.Length - 2);
                    return formattedDate;

                }
                else
                {
                    string timeEnding = " PM";
                    string time = Convert.ToString(dateTime);
                    if (dateTime < 1200)
                    {
                        timeEnding = " AM";
                    }
                    string formattedTime = time.Substring(0, time.Length - 2) + ":" + time.Substring(time.Length - 2) + timeEnding;
                    return formattedTime;
                }
            }
            else
            {
                return "- - - -";
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
            dataGridView1.Rows.Clear();
            BusRecord[] tempRecord;
            if(cmbBxBusTypes.SelectedIndex == 1)
            {
                tempRecord = sportBusRecordArray[busIndex];
            }
            else
            {
                tempRecord = busRecordArray[busIndex];
            }

            int averageArrivalTime = 0;
            int averageDepartureTime = 0;
            int arrivalCount = 0;
            int departCount = 0;

            for(int i = tempRecord.Length -1; i>-1; i--) {
                BusRecord b = tempRecord[i];
                string status;
                if (b.atSchool == true)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                string[] data = { b.busNumber.ToString(), status, DateTimeFormat(b.arrivalTime, "time"), DateTimeFormat(b.departTime, "time"), DateTimeFormat(b.arrivalDate, "date") };
                dataGridView1.Rows.Add(data);

                if (cmbBxBusTypes.SelectedIndex == 0)
                {
                    if (b.arrivalTime > 700 && b.departTime < 1000)
                    {
                        averageArrivalTime += b.arrivalTime;
                        averageDepartureTime += b.departTime;
                        arrivalCount += 1;
                        departCount += 1;
                    }
                }
                else
                {
                    if (b.arrivalTime < 1900 && b.departTime > 1200)
                    {
                        averageArrivalTime += b.arrivalTime;
                        averageDepartureTime += b.departTime;
                        arrivalCount += 1;
                        departCount += 1;
                    }
                }
            }

            lblAvgArrTimeValue.Text = DateTimeFormat(averageArrivalTime / arrivalCount, "time");
            lblAvgDeptTimeValue.Text = DateTimeFormat(averageDepartureTime / departCount, "time");
        }

        void FillComboBox(string filePath)
        {
            cmbBxBuses.Items.Clear();
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
        List<BusRecord[]> sportBusRecordArray = new List<BusRecord[]>();
        string[] busTypes = new string[] { "School", "Sport" };

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbBxBusTypes.Items.AddRange(busTypes);

            for (int i = 1; i < 22; i++)
            {
                ReadFile(i, "school");
                busRecordArray.Add(busRecord);
            }
            for (int i = 1; i < 7; i++)
            {
                ReadFile(i, "sport");
                sportBusRecordArray.Add(busRecord);
            }
        }

        private void cmbBxBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxBuses.SelectedIndex != -1)
            {
                DisplayData(Convert.ToInt32(cmbBxBuses.SelectedIndex.ToString()));
            }
        }

        private void cmbBxBusTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBxBuses.SelectedIndex = -1;

            if (cmbBxBusTypes.SelectedIndex == 1) {
                FillComboBox("SportsBusList.txt");
            }
            else
            {
                FillComboBox("BusList.txt");
            }
        }
    }
}
