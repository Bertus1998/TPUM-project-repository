
using Data_Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic_Server
   {
    internal class StationManager: AStationManager
    {
        List<Thread> threads = new List<Thread>();
       public StationManager()
        {
            this.MaxHeat = 35;
            this.stations = DataStation.GetStations(10);
            ///Taska
            foreach(DataStation station in stations)
            {
                Console.WriteLine(station.ToString());
                Thread tempThread = new Thread(() => simulation(station));
                threads.Add(tempThread);
                tempThread.Start();
            }
        }
       public StationManager(List<DataStation> dataStations)
        {
            this.MaxHeat = 35;
            this.stations = dataStations;
            foreach (DataStation station in stations)
            {
                Thread tempThread = new Thread(() => simulation(station));
                threads.Add(tempThread);
                tempThread.Start();
            }
        }
     
        private List<DataStation> stations;
      
        public List<DataStation> Stations
        {
            get { return stations; }
            set { stations = value; }
        }

        public override void AddStation(string name)
        {
            bool was = false;
            foreach(DataStation  station in Stations)
            {
               if(name == station.Name)
                {
                    was = true;
                }
            }
            if(!was)
            {
            DataStation dataStation = DataStation.createStation(name);
            Thread tempThread = new Thread(() => simulation(dataStation));
            threads.Add(tempThread);
            tempThread.Start();
            stations.Add(dataStation);
            }
        }

        public override void DecreaseTargetTemp(int number)
        {
            if (number >= 0)
            {
                stations[number].TargetTemp -= 1;
            }
        }

        public override void DeleteStation(int number)
        {
            if(number>=0&&number<stationCount())
            {
                Stations.RemoveAt(number);
               
                threads.RemoveAt(number);
            }
        
        }

        public override string[] getStation(int numer)
        {
            if(numer>= stations.Count||numer<0)
            {
                return null;
            }
            else
            {
                string[] parameters = { stations[numer].Name, stations[numer].NowTemp.ToString(), stations[numer].TargetTemp.ToString() };
                return parameters;
            }
      
       
        }
        public override void IncreaseTargetTemp(int number)
        {
            if (number >= 0)
            {
                stations[number].TargetTemp += 1;
            }
        }

        public override void IncreaseMaxTemp()
        {
            this.MaxHeat += 1;
        }

        public override void DecreaseMaxTemp()
        {
            this.MaxHeat -= 1;
        }
        public void  simulation(DataStation station)
        {
            while(true)
            {
                Thread.Sleep(1500);
                station.simulateTemp(this.MaxHeat);
            }
        }

        public override int stationCount()
        {

            return stations.Count;
        }

        public override int getNumberStation(string name)
        {
               for(int i =0; i<this.stationCount(); i++)
            {
                if (this.stations[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public override void realization(string[] lol, int number)
        {

            Console.WriteLine(number);
        }

        public override DataStation getObjectStation(int number)
        {
            return this.stations[number];
        }
    }
}
