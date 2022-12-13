using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomSniper
{
    public class links
    {

        public string link { get; set; }
        public bool[] days { get; set; }
        public int hour;
        public int minute;
        public int openCounter = 0;
        public string name { get; set; }
        public bool isChecked = false;

        //parameterized constructor
        public links(string link, bool[] days, int hour, int minute, string name)
        {
            this.link = link;
            this.days = days;
            this.hour = hour;
            this.minute = minute;
            this.name = name;

        }
        //default constructor
        public links()
        {

        }
        //copy constructor
        public links(links linkObj)
        {
            link = linkObj.link;
            days = linkObj.days;
            hour = linkObj.hour;
            minute = linkObj.minute;
            name = linkObj.name;
            isChecked = linkObj.isChecked;
        }


    }
}
