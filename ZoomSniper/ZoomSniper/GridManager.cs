using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomSniper
{
    public class GridManager
    {
        KryptonDataGridView gridViewMain;
        List<links> linkList;

        public void appStarup(ref List<links> linkList, ref KryptonDataGridView gridViewMain)
        {
            this.gridViewMain = gridViewMain;
            this.linkList = linkList;

            initGridView();

            listToGridView();

            
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
            //Lock handler during update
            gridViewMain.Enabled = false;

            gridViewMain.Rows.Clear();
            initGridView();
            //Add items in the gridview
            string[] arr = new string[10];
            DataGridViewRow item1;

            //Loop though List
            int currentRow = 0;
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
                //arr[0] = linksList.isChecked.ToString();
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

                gridViewMain.Rows.Add(arr);
                gridViewMain.Rows[currentRow].Selected = linksList.isChecked;

                currentRow++;
            }
            //Unlock handler after reset
            gridViewMain.Enabled = true;
        }
        private void initGridView()
        {
            //initTest();

            int checkWidth = 40;


            gridViewMain.ReadOnly = true;

            /*
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.ValueType = typeof(bool);
            checkCol.Name = "Chk";
            checkCol.HeaderText = "";
            checkCol.Width = 25;
            checkCol.ReadOnly = false;
            gridViewMain.Columns.Add(checkCol);
            */


            gridViewMain.ColumnCount = 10;
            gridViewMain.RowHeadersVisible = false;

            for (int i = 0; i < 10; i++)
            {
                gridViewMain.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //385
            gridViewMain.Columns[0].Name = "Name";
            gridViewMain.Columns[0].Width = 192;

            gridViewMain.Columns[1].Name = "Link";
            gridViewMain.Columns[1].Width = 228; //211

            gridViewMain.Columns[2].Name = "S";
            gridViewMain.Columns[2].Width = checkWidth;

            gridViewMain.Columns[3].Name = "M";
            gridViewMain.Columns[3].Width = checkWidth;

            gridViewMain.Columns[4].Name = "T";
            gridViewMain.Columns[4].Width = checkWidth;

            gridViewMain.Columns[5].Name = "W";
            gridViewMain.Columns[5].Width = checkWidth;

            gridViewMain.Columns[6].Name = "R";
            gridViewMain.Columns[6].Width = checkWidth;

            gridViewMain.Columns[7].Name = "F";
            gridViewMain.Columns[7].Width = checkWidth;

            gridViewMain.Columns[8].Name = "S";
            gridViewMain.Columns[8].Width = checkWidth;

            gridViewMain.Columns[9].Name = "Time";
            gridViewMain.Columns[9].Width = 80;


        }
    }
}
