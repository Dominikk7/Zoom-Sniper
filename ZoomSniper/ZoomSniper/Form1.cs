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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ZoomSniper
{
    public partial class Form1 : KryptonForm
    {
        public List<links> linkList = new List<links>();
        public static string path1 = @"%APPDATA%\ZoomSniper\";
        public string path2 = @"%APPDATA%\ZoomSniper\bigData.xml";
        public string pathTest;
        public string pathDirectory;
        public static Form1 instance;

        public Form1()
        {
            instance = this;
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

            initGridView();

            listToGridView();

            updateSelected();

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

            //For progress bar inticator
            bool anyDayMatches = false;
            double lowestTime = -1;
            string lowestName = "";

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

                if (dayMatches)
                {
                    anyDayMatches = true;
                    
                    //Get time offset
                    var date = DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
                    date = date.AddHours(linksList.hour);
                    date = date.AddMinutes(linksList.minute);
                    var now = DateTime.Now;

                    double result = date.Subtract(now).TotalMinutes;
                    //Set valid lowest time
                    if (result >= 0)
                    {
                        if(lowestTime == -1)
                        {
                            lowestTime = result;
                            lowestName = linksList.name;
                        }
                        else if(lowestTime > result)
                        {
                            lowestTime = result;
                            lowestName = linksList.name;
                        }

                    }
                }


            }
            //Progress bar and text
            if (!anyDayMatches || lowestTime == -1)
            {
                nextLink.Text = "No more links today";
            }
            else
            {
                lowestTime = Math.Round(lowestTime, 1);
                nextLink.Text = lowestName + ": "+lowestTime.ToString() + " minutes";
            }


        }
        private bool dayMatchesCheck(string currentDay, string checkedDay)
        {
            return currentDay.Equals(checkedDay);
        }

        private string checkMark(bool b)
        {
            if (b)
            {
                return "✔";
            }
            return "";
        }

        public void listToGridView()
        {

            gridViewMain.Columns.Clear();
            initGridView();
            //Add items in the gridview
            string[] arr = new string[11];
            DataGridViewRow item1;

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
                arr[0] = linksList.isChecked.ToString();
                arr[1] = linksList.name;
                arr[2] = linksList.link;
                arr[3] = checkMark(linksList.days[0]);
                arr[4] = checkMark(linksList.days[1]);
                arr[5] = checkMark(linksList.days[2]);
                arr[6] = checkMark(linksList.days[3]);
                arr[7] = checkMark(linksList.days[4]);
                arr[8] = checkMark(linksList.days[5]);
                arr[9] = checkMark(linksList.days[6]);
                arr[10] = timeString;

                gridViewMain.Rows.Add(arr);
            
            }
            
        }
        
        private void initTest()
        {
            var source = new BindingSource();
            List<links> list = new List<links> { new links("t",null,1,1,"test2")};
            source.DataSource = list;
            gridViewMain.DataSource = source;
            gridViewMain.AutoGenerateColumns = true;
        }
        private void initGridView()
        {
            //initTest();

            int checkWidth = 40;


            gridViewMain.ReadOnly = true;

            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.ValueType = typeof(bool);
            checkCol.Name = "Chk";
            checkCol.HeaderText = "";
            checkCol.Width = 25;
            checkCol.ReadOnly = false;
            gridViewMain.Columns.Add(checkCol);
            

            gridViewMain.ColumnCount = 11;
            gridViewMain.RowHeadersVisible = false;

            for(int i=0; i<11; i++)
            {
                gridViewMain.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //385
            gridViewMain.Columns[1].Name = "Name";
            gridViewMain.Columns[1].Width = 192;

            gridViewMain.Columns[2].Name = "Link";
            gridViewMain.Columns[2].Width = 228; //211

            gridViewMain.Columns[3].Name = "S";
            gridViewMain.Columns[3].Width = checkWidth;

            gridViewMain.Columns[4].Name = "M";
            gridViewMain.Columns[4].Width = checkWidth;

            gridViewMain.Columns[5].Name = "T";
            gridViewMain.Columns[5].Width = checkWidth;

            gridViewMain.Columns[6].Name = "W";
            gridViewMain.Columns[6].Width = checkWidth;

            gridViewMain.Columns[7].Name = "R";
            gridViewMain.Columns[7].Width = checkWidth;

            gridViewMain.Columns[8].Name = "F";
            gridViewMain.Columns[8].Width = checkWidth;

            gridViewMain.Columns[9].Name = "S";
            gridViewMain.Columns[9].Width = checkWidth;

            gridViewMain.Columns[10].Name = "Time";
            gridViewMain.Columns[10].Width = 80;


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
            addForm(-1);
        }

        private void deleteLink_Click(object sender, EventArgs e)
        {
            //Loop though listView
            int i = 0;;

            while (i < linkList.Count())
            {
                if (linkList[i].isChecked)
                {
                    linkList.RemoveAt(i);
                    //Amount of times deleted
                    i--;
                    
                }
                i++;

            }
            listToGridView();

            //Reset selected
            selectLabel.Text = "0 selected";

            //Save data
            SerializeListData();
        }

        private void gridViewMain_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Open link on double click
            if(e.RowIndex != -1 && e.ColumnIndex != 0)
            {
                openLink(linkList[e.RowIndex].link);
            }
        }
        private void gridViewMain_ItemClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check or uncheck all
            if(e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                //if any checked -> unckeck all
                bool anyChecked = false;
                foreach(links row in linkList)
                {
                    if (row.isChecked)
                    {
                        anyChecked = true;
                        row.isChecked = false;
                    }
                }
                //else check all
                if (!anyChecked)
                {
                    foreach (links row in linkList)
                    {
                        row.isChecked = true;
                    }
                }

                listToGridView();

            }
            
            if(e.ColumnIndex == 0 && e.RowIndex != -1)
            {

                bool oldCheck = linkList[e.RowIndex].isChecked;

                if (oldCheck)
                {
                    linkList[e.RowIndex].isChecked = false;
                    gridViewMain.Rows[e.RowIndex].Cells[0].Value = false;
                    //MessageBox.Show(linkList[e.RowIndex].name + " unchecked");
                }
                else
                {
                    linkList[e.RowIndex].isChecked = true;
                    gridViewMain.Rows[e.RowIndex].Cells[0].Value = true;
                    //MessageBox.Show(linkList[e.RowIndex].name+ " checked");
                }


                gridViewMain.EndEdit();

            }
            updateSelected();

        }

        public void updateSelected()
        {
            int count = 0;

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

            while (i < linkList.Count())
            {
                if (linkList[i].isChecked)
                {
                    if (i == linkList.Count() - 1)
                    {
                        return;
                    }
                    else
                    {
                        index.Add(i);
                        newIndex.Add(i + 1);
                        if (!linkList[i+1].isChecked)
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
            listToGridView();

            //Save data
            SerializeListData();

        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<int> index = new List<int>();
            List<int> uncheck = new List<int>();
            List<int> newIndex = new List<int>();

            while (i < linkList.Count())
            {
                if (linkList[i].isChecked)
                {
                    if (i == 0)
                    {
                        return;
                    }
                    else
                    {
                        index.Add(i);
                        newIndex.Add(i - 1);
                        if (!linkList[i-1].isChecked)
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
            listToGridView();

            //Save data
            SerializeListData();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(links link in linkList)
            {
                if (link.isChecked)
                {
                    addForm(i);
                }
                i++;
            }
        }

        private void addForm(int index)
        {
            var addForm = new Form2(ref linkList, index);
            addForm.Show();
        }

        private void selectLabel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
