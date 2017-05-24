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
        public List<string> sections;
        public List<string> Sections
        {
            get { return sections; }
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
            subwayStations = JsonConvert.DeserializeObject<List<SubwayStation>>(File.ReadAllText("../../../SportIS.Data/Files/SubwayStations.json"));
            sportClubs = JsonConvert.DeserializeObject<List<SportClub>>(File.ReadAllText("../../../SportIS.Data/Files/SportClubs.json"));
            sportActivities = JsonConvert.DeserializeObject<List<SportActivity>>(File.ReadAllText("../../../SportIS.Data/Files/SportActivities.json"));
            sections = new List<string>();
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
        public void Serialize(List<SportActivity> sport, string file)
        {
            string str = JsonConvert.SerializeObject(sport);
            File.WriteAllText(file, str);
        }
        public List<SportActivity> Deserialize(string file)
        {
            List<SportActivity> activities = JsonConvert.DeserializeObject<List<SportActivity>>(File.ReadAllText(file));
            for (int i = 0; i < activities.Count; i++)
            {
                if (activities[i].Title == null || activities[i].Type == null)
                {
                    throw new ArgumentException("Загруженный Вами файл имеет неверный формат");
                }
                sportActivities.AddRange(activities);
            }
            return activities;
        }
        public List<SportActivity> Search(double priceMin, double priceMax, string type, string metroStation)
        {
            var filtered = SportActivities.Where(x =>
                (

                   (priceMin == -1 && priceMax == 100000 ? true : x.Price >= priceMin && x.Price <= priceMax)
                    && (type == "" ? true : x.Type.Equals(type))
                    && (metroStation == "" ? true : x.Club.Stations.Contains(metroStation))
                )).ToList();
            return filtered;
        }

    }
}
