using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportIS.Data
{
    public class SportClub
    {
        private int id;
        private string name;

        public string ClubName
        {
            get { return name; }

        }
        private List<string> stations;

        public List<string> Stations
        {
            get { return stations; }
            set { stations = value; }

        }
        private string  address;

        public string Address
        {
            get { return address; }
           
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public SportClub(string name, List<string> stations, string address, string phone)
        {
            this.stations = stations;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public override bool Equals(object obj)
        {
            return name.Equals(obj.ToString());
        }
        public override string ToString()
        {
            return name;
        }




    }
}
