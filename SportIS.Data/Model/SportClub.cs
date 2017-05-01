using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportIS.Data
{
    class SportClub
    {
        private int id;
        private string name;

        public string ClubName
        {
            get { return name; }

        }
        private List<SubwayStation> station;

        public List<SubwayStation> Station
        {
            get { return station; }
            set { station = value; }

        }
        private string  address;

        public string Address
        {
            get { return address; }
           
        }





    }
}
