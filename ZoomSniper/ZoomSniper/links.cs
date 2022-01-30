using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomSniper
{
    public class links
    {

        public string link;
        public bool[] days;
        public int hour;
        public int minute;
        public int openCounter = 0;
        public string name;


        public links(string link, bool[] days, int hour, int minute, string name)
        {
            this.link = link;
            this.days = days;
            this.hour = hour;
            this.minute = minute;
            this.name = name;

        }

        public links()
        {

        }

    }
}
