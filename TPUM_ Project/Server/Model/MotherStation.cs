using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class MotherStation
    {
        public MotherStation()
        {
            this.stations = new List<Station>();
            for(int i =0;i<10; i++)
            {
                this.addStation(new Station(i.ToString()));
            }
        }
        private List<Station> stations
        {
            get;
            set;
        }
        public List<Station> Stations
        {
            get { return stations; }
            set { stations = value;}
        }
        public void addStation(Station station)
        {
            this.stations.Add(station);
        }
        public void removeStation(Station station)
        {
            this.stations.Remove(station);
        }
    }
}
