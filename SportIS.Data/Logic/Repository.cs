using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SportIS.Data.Logic
{
    public class Repository
    {

        private List<SubwayStation> subwayStations;
        public List<SubwayStation> SubwayStations
        {
            get { return subwayStations; }         
        }
        private List<SportClub> sportClubs;
        public List<SportClub> SportClubs
        {
            get { return sportClubs; }
        }
        private List<SportActivity> sportActivities;
        public List<SportActivity> SportActivities
        {
            get { return sportActivities; }

        }
        private static readonly Lazy<Repository> instanceHolder =
        new Lazy<Repository>(() => new Repository());

        public static Repository Instance
        {
            get { return instanceHolder.Value; }
        }
        public Repository()
        {
            subwayStations =  JsonConvert.DeserializeObject<List<SubwayStation>>(File.ReadAllText("../../../SportIS.Data/Files/SubwayStations.json"));
            sportClubs = JsonConvert.DeserializeObject<List<SportClub>>(File.ReadAllText("../../../SportIS.Data/Files/SportClubs.json"));
            sportActivities = JsonConvert.DeserializeObject<List<SportActivity>>(File.ReadAllText("../../../SportIS.Data/Files/SportActivities.json"));

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
        public void AddSportActivity(SportActivity s)
        {
            sportActivities.Add(s);
        }
        public void Serialize( List<SportActivity> sport)
        {
            string str = JsonConvert.SerializeObject(sport);
            File.WriteAllText("../../../SportIS.Data/Files/SportActivities.json",str);
        }
        public SportActivity Deserialize(string file)
        {
           
            return null;
        }

    }
}
