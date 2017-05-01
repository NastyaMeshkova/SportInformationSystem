using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportIS.Data.Logic
{
    class Repository
    {
        private List<SubwayStation> SubwayStations;
        private List<SportClub> SportClubs;
        private List<SportActivity> SportActivities;
        public Repository()
        {
            //метро
            //да вообще все
        }
        public void AddSubway(SubwayStation subway)
        {
            SubwayStations.Add(subway);
        }
        public void AddSportClub(SportClub s)
        {
            SportClubs.Add(s);
        }
        public void DeleteSportClub()
        {

        }
        public void Serialize( SportActivity sport)
        {

        }
        public SportActivity Deserialize(string file)
        {
            SportActivity s = new SportActivity();
            return null;
        }

    }
}
