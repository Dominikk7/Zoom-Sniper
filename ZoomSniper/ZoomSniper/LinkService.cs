using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomSniper
{
    internal class LinkService
    {
        List<links> linkList;
        KryptonLabel nextLink;
        public LinkService(ref List<links> linkList, ref KryptonLabel nextLink)
        {
            this.linkList = linkList;
            this.nextLink = nextLink;
        }

        public async void checkAsync()
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
                        LinkUtils.openLink(linksList.link);
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
                        if (lowestTime == -1)
                        {
                            lowestTime = result;
                            lowestName = linksList.name;
                        }
                        else if (lowestTime > result)
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
                //Cut lowestName name length
                if (lowestName.Length > 20)
                {
                    lowestName = lowestName.Substring(0, 20);
                }
                nextLink.Text = lowestName + ": " + lowestTime.ToString() + " minutes";
            }


        }
        private bool dayMatchesCheck(string currentDay, string checkedDay)
        {
            return currentDay.Equals(checkedDay);
        }
    }
}
