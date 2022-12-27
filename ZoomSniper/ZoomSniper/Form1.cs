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
        public static Form1 instance;

        //Object for data load and save
        public SaveManager saveManager = new SaveManager();

        //Object to manage dataGridView
        public GridManager gridManager = new GridManager();

        public Form1()
        {
            //WFA components
            instance = this;
            InitializeComponent();

            //Load app data
            saveManager.appStarup(ref linkList, ref updateBtn);

            //Start grid view
            gridManager.appStarup(ref linkList, ref gridViewMain);

            //Update #selected text
            updateSelected();

            //Start link checking service
            LinkService checkLink = new LinkService(ref linkList, ref nextLink);
            checkLink.checkAsync();

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
            gridManager.listToGridView();

            //Reset selected
            selectLabel.Text = "0 selected";

            //Save data
            saveManager.SerializeListData(ref linkList);
        }

        private void gridViewMain_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Open link on double click
            if(e.RowIndex != -1)
            {
                LinkUtils.openLink(linkList[e.RowIndex].link);
            }
        }

        private void gridViewMain_SelectChange(object sender, EventArgs e)
        {
            //Only change selected when enabled(user interaction)
            if(gridViewMain.Enabled)
            {
                for (int i = 0; i < linkList.Count(); i++)
                {
                    if (gridViewMain.Rows[i].Selected)
                    {
                        linkList[i].isChecked = true;
                    }
                    else
                    {
                        linkList[i].isChecked = false;
                    }
                }
                updateSelected();
            }
            

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
            gridManager.listToGridView();

            //Save data
            saveManager.SerializeListData(ref linkList);

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
            gridManager.listToGridView();

            //Save data
            saveManager.SerializeListData(ref linkList);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            LinkUtils.openLink(updateBtn.AccessibleDescription);
        }
    }
}
