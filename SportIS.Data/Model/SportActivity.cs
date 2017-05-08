using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportIS.Data
{
    public class SportActivity
    {
        private string title;

        public string Title
        {
            get { return title; }
        }
        private SportClub club;

        public SportClub Club
        {
            get { return club; }
        }
        private string description;

        public string Description
        {
            get { return description; }
        }
        public SportActivity(string title, SportClub club, string description,Dictionary<string,string> wt)
        {
            this.title = title;
            this.club = club;
            this.description = description;
            weekday_time = wt;
        }
        private Dictionary<string,string> weekday_time;

        public Dictionary<string,string> WeekDayTime
        {
            get { return weekday_time; }
        }

    }
}
