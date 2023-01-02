using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomSniper
{
    public partial class Form2 : KryptonForm
    {
        List<links> linkList;
        int index = -1;

        public Form2(ref List<links> linkList, int index)
        {
            InitializeComponent();
            dateBoxInit();
            this.linkList = linkList;
            this.index = index;

            if(index != -1)
            {
                editDisplay();
            }
        }

        private void dateBoxInit()
        {
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.ShowUpDown = true;
        }

        private bool addLinkFromInput()
        {
            //Convert checkboxes to boolean
            bool[] days = new bool[7];
            days[0] = sBox.Checked;
            days[1] = mBox.Checked;
            days[2] = tBox.Checked;
            days[3] = wBox.Checked;
            days[4] = rBox.Checked;
            days[5] = fBox.Checked;
            days[6] = saBox.Checked;

            //Convert time to int and string
            int hours = timePicker.Value.Hour;
            int minutes = timePicker.Value.Minute;

            //Get link
            string link = linkBox.Text;

            //Data verification
            if (link.Length > 1)
            {
                //Construct link object
                links tempLink = new links(link, days, hours, minutes, nameBox.Text);

                //edit or add

                if(index == -1)
                {
                    //Add to arrayList
                    linkList.Add(tempLink);
                }
                else
                {
                    //Edit arrayList
                    linkList[index] = tempLink;
                }
                return true;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter link");
                return false;
            }
        }
        private void editDisplay()
        {
            nameBox.Text = linkList[index].name;
            linkBox.Text = linkList[index].link;
            sBox.Checked = linkList[index].days[0];
            mBox.Checked = linkList[index].days[1];
            tBox.Checked = linkList[index].days[2];
            wBox.Checked = linkList[index].days[3];
            rBox.Checked = linkList[index].days[4];
            fBox.Checked = linkList[index].days[5];
            saBox.Checked = linkList[index].days[6];

            var date = DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
            date = date.AddHours(linkList[index].hour);
            date = date.AddMinutes(linkList[index].minute);

            timePicker.Value = date;


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool success = addLinkFromInput();
            Form1.instance.gridManager.listToGridView();
            if (success)
            {
                //Save after adding
                Form1.instance.saveManager.SerializeListData(ref linkList);
                Form1.instance.updateSelected();

                //Close
                this.Close();
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void nameLabel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form2_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //Enable form1 when it is only window
            int form2Count = Application.OpenForms.OfType<Form2>().Count();
            if(form2Count == 1)
            {
                Form1.instance.Enabled = true;
            }

        }

    }
}
