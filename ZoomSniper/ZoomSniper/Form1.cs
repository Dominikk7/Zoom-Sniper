using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ComponentFactory.Krypton.Toolkit;

namespace ZoomSniper
{
    public partial class Form1 : KryptonForm
    {
        public List<links> linkList = new List<links>();
        public static string path1 = @"%APPDATA%\ZoomSniper\";
        public string path2 = @"%APPDATA%\ZoomSniper\bigData.xml";
        public string pathTest;
        public string pathDirectory;

        public Form1()
        {

            InitializeComponent();
            //Create files if needed
            pathDirectory = Environment.ExpandEnvironmentVariables(path1);
            pathTest = Environment.ExpandEnvironmentVariables(path2);

            //Make sure directory exists
            try
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(pathDirectory);
            }
            catch (Exception e)
            {

            }

            if (!(File.Exists(pathTest)))
            {
                SerializeListData();
            }
            DeserializeListData();

            dateBoxInit();
            initListView();
            listToListView();

            checkAsync();

        }
        private async void checkAsync()
        {
            while (true)
            {
                checkTime();
                await PutTaskDelay();
            }
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(5000);
        }

        private void openLink(string link)
        {
            //if ((!link.StartsWith("http://", StringComparison.OrdinalIgnoreCase)) || (!link.StartsWith("https://"))) link = "http://" + link;
            //System.Windows.Forms.MessageBox.Show(link);

            if (!link.StartsWith("http://") && !link.StartsWith("https://"))
            {
                link = "http://" + link;
            }

            //Process.Start("explorer", link);
            System.Diagnostics.Process.Start(link);
        }
        private void checkTime()
        {
            string timeNow;
            var localDate = DateTime.Now;
            string dayOfWeek = localDate.DayOfWeek.ToString();
            timeNow = localDate.ToString("HH:mm");
            string hour = timeNow.Substring(0, timeNow.IndexOf(":"));
            string minute = timeNow.Substring(timeNow.IndexOf(":") + 1);
            int hourInt = Int16.Parse(hour);
            int minuteInt = Int16.Parse(minute);


            //Loop though List
            foreach (links linksList in linkList)
            {
                bool dayMatches = false;
                //Check if day matches
                bool[] days = linksList.days;
                int i = 0;
                while (i < days.Length)
                {
                    if (days[i])
                    {
                        //System.Windows.Forms.MessageBox.Show("i: "+i);
                        if (i == 0 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Sunday");
                        }
                        else if (i == 1 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Monday");
                        }
                        else if (i == 2 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Tuesday");
                        }
                        else if (i == 3 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Wednesday");
                        }
                        else if (i == 4 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Thursday");
                        }
                        else if (i == 5 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Friday");
                        }
                        else if (i == 6 && !dayMatches)
                        {
                            dayMatches = dayMatchesCheck(dayOfWeek, "Saturday");
                        }
                    }

                    i++;
                }

                //System.Windows.Forms.MessageBox.Show("hour " + hourInt + " hour link " + linksList.hour + " "+ " minute " + minuteInt + " minute link " + linksList.minute);

                if (((hourInt == linksList.hour) && Math.Abs(minuteInt - linksList.minute) < 1) && dayMatches) //minute accuracy
                {
                    linksList.openCounter++;

                    if (linksList.openCounter == 1)
                    {
                        openLink(linksList.link);
                        //System.Windows.Forms.MessageBox.Show("match");
                    }

                }
                else
                {
                    linksList.openCounter = 0;
                }



            }
        }
        private bool dayMatchesCheck(string currentDay, string checkedDay)
        {
            return currentDay.Equals(checkedDay);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateBoxInit()
        {
            this.dateTimePicker1.CustomFormat = "hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ShowUpDown = true;
        }


        private void addLinkFromInput()
        {
            //Convert checkboxes to boolean
            bool[] days = new bool[7];
            days[0] = checkBox1.Checked;
            days[1] = checkBox2.Checked;
            days[2] = checkBox4.Checked;
            days[3] = checkBox3.Checked;
            days[4] = checkBox5.Checked;
            days[5] = checkBox6.Checked;
            days[6] = checkBox7.Checked;

            //Convert time to int and string
            int hours = dateTimePicker1.Value.Hour;
            int minutes = dateTimePicker1.Value.Minute;

            //Get link
            string link = textBox1.Text;

            //Data verification
            if (link.Length > 1)
            {
                //Construct link object
                links tempLink = new links(link, days, hours, minutes, customBox.Text);

                //Add to arrayList
                linkList.Add(tempLink);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter link");
            }
        }

        private string checkMark(bool b)
        {
            if (b)
            {
                return "✔";
            }
            return "";
        }

        private void listToListView()
        {
            listViewMain.Clear();
            initListView();

            //Add items in the listview
            string[] arr = new string[10];
            ListViewItem item1;

            //Loop though List
            foreach (links linksList in linkList)
            {
                //Parse time
                int hours = linksList.hour;
                int minutes = linksList.minute;
                string timeOfDay = "";
                string timeString;


                if (hours >= 12 && hours != 24)
                {
                    timeOfDay = "PM";
                }
                else
                {
                    timeOfDay = "AM";
                }

                if (hours > 12)
                {
                    hours -= 12;
                }
                if (hours == 0)
                {
                    hours = 12;
                }
                if (minutes < 10)
                {
                    timeString = hours + ":" + "0" + minutes + timeOfDay;
                }
                else
                {
                    timeString = hours + ":" + minutes + timeOfDay;
                }

                arr[0] = linksList.name;
                arr[1] = linksList.link;
                arr[2] = checkMark(linksList.days[0]);
                arr[3] = checkMark(linksList.days[1]);
                arr[4] = checkMark(linksList.days[2]);
                arr[5] = checkMark(linksList.days[3]);
                arr[6] = checkMark(linksList.days[4]);
                arr[7] = checkMark(linksList.days[5]);
                arr[8] = checkMark(linksList.days[6]);
                arr[9] = timeString;
                item1 = new ListViewItem(arr);
                
                item1.Checked = linksList.isChecked;



                listViewMain.Items.Add(item1);
            }


        }

        private void initListView()
        {
            listViewMain.View = View.Details;
            listViewMain.CheckBoxes = true;
            listViewMain.GridLines = true;


            listViewMain.Columns.Add("Name", 80);
            listViewMain.Columns.Add("Link", 80);
            listViewMain.Columns.Add("S", 40);
            listViewMain.Columns.Add("M", 40);
            listViewMain.Columns.Add("T", 40);
            listViewMain.Columns.Add("W", 40);
            listViewMain.Columns.Add("T", 40);
            listViewMain.Columns.Add("F", 40);
            listViewMain.Columns.Add("S", 40);
            listViewMain.Columns.Add("Time", 70);
        }

        public void SerializeListData()
        {
            pathTest = Environment.ExpandEnvironmentVariables(path2);

            XmlSerializer ser = new XmlSerializer(typeof(List<links>));
            TextWriter writer = new StreamWriter(pathTest);
            ser.Serialize(writer, linkList);
            writer.Close();
        }

        public void DeserializeListData()
        {
            pathTest = Environment.ExpandEnvironmentVariables(path2);

            XmlSerializer serializer = new XmlSerializer(typeof(List<links>));

            StreamReader reader = new StreamReader(pathTest);
            linkList = (List<links>)serializer.Deserialize(reader);
            reader.Close();
        }

        private void addLink_Click(object sender, EventArgs e)
        {
            //Add link to List
            addLinkFromInput();

            //Display list onto listView
            listToListView();

            //Save data
            SerializeListData();
        }

        private void deleteLink_Click(object sender, EventArgs e)
        {
            //Loop though listView
            int i = 0;
            int j = 0;

            while (i < listViewMain.Items.Count)
            {
                if (listViewMain.Items[i].Checked)
                {
                    linkList.RemoveAt(i - j); //account for index discrepancy
                    //Amount of times deleted
                    j++;
                }
                i++;

            }
            listToListView();

            //Reset selected
            selectLabel.Text = "0 selected";

            //Save data
            SerializeListData();
        }

        private void listViewMain_ItemCheck1(object sender, ItemCheckEventArgs e)
        {
            int count = 0;

            //not already checked
            if (e.CurrentValue != CheckState.Checked)
            {
                linkList[e.Index].isChecked = true;
            }
            //already checked
            else
            {
                linkList[e.Index].isChecked = false;
            }

            foreach (links linksList in linkList)
            {
                if (linksList.isChecked)
                {
                    ++count;
                }
            }

                selectLabel.Text = count + " selected";

        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<int> index = new List<int>();
            List<int> uncheck = new List<int>();
            List<int> newIndex = new List<int>();

            while (i < listViewMain.Items.Count)
            {
                if (listViewMain.Items[i].Checked)
                {
                    if (i == listViewMain.Items.Count - 1)
                    {
                        return;
                    }
                    else
                    {
                        index.Add(i);
                        newIndex.Add(i + 1);
                        if (!listViewMain.Items[i + 1].Checked)
                        {
                            uncheck.Add(i + 1);               
                        }
                    }
                }
                i++;
            }

            for (int j = 0; j < uncheck.Count; j++)
            {
                bool found = true;
                index.Add(uncheck[j]);
                while (found)
                {
                    uncheck[j] -= 1;
                    for (int k = 0; k < newIndex.Count; k++)
                    {
                        found = false;
                        if (uncheck[j] == newIndex[k])
                        {
                            found = true;
                            break;
                        }
                    }
                }
                newIndex.Add(uncheck[j]);
                
            }

            List<links> linkObj = new List<links>();

            for (i = 0; i < index.Count; i++)
            {
                links temp = linkList[index[i]];
                linkObj.Add(temp);
            }

            for(i = 0; i < linkObj.Count; i++)
            {
                linkList[newIndex[i]] = linkObj[i];
            }
            listToListView();

            //Save data
            SerializeListData();

        }

       

        private void upBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<int> index = new List<int>();
            List<int> uncheck = new List<int>();
            List<int> newIndex = new List<int>();

            while (i < listViewMain.Items.Count)
            {
                if (listViewMain.Items[i].Checked)
                {
                    if (i == 0)
                    {
                        return;
                    }
                    else
                    {
                        index.Add(i);
                        newIndex.Add(i - 1);
                        if (!listViewMain.Items[i - 1].Checked)
                        {
                            uncheck.Add(i - 1);
                        }
                    }
                }
                i++;
            }

            for (int j = 0; j < uncheck.Count; j++)
            {
                bool found = true;
                index.Add(uncheck[j]);
                while (found)
                {
                    uncheck[j] += 1;
                    for (int k = 0; k < newIndex.Count; k++)
                    {
                        found = false;
                        if (uncheck[j] == newIndex[k])
                        {
                            found = true;
                            break;
                        }
                    }
                }
                newIndex.Add(uncheck[j]);

            }

            List<links> linkObj = new List<links>();

            for (i = 0; i < index.Count; i++)
            {
                links temp = linkList[index[i]];
                linkObj.Add(temp);
            }

            for (i = 0; i < linkObj.Count; i++)
            {
                linkList[newIndex[i]] = linkObj[i];
            }
            listToListView();

            //Save data
            SerializeListData();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            listToListView();
        }
    }
}
