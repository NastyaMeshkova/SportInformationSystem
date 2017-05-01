using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportIS.Data
{
    class SubwayStation
    {
        int ID { get;  }
        string StationTitle { get;  }
        public SubwayStation( int id, string name)
        {
            ID = id;
            StationTitle = name;
        }

    }
}
