
using Data_Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Server
{
    public abstract class AStationManager: INotifyPropertyChanged
    {
        private int maxHeat;
        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        public int MaxHeat
        {
            get { return maxHeat; }
            set
            {
                this.maxHeat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MaxHeat"));
            }
        }
        public abstract void IncreaseMaxTemp();
        public abstract void DecreaseMaxTemp();
        public abstract void IncreaseTargetTemp(int number);
        public abstract void DecreaseTargetTemp(int number);
        public abstract void DeleteStation(int number);
        public abstract void AddStation(String name);
        public abstract string[] getStation(int number);
        public abstract DataStation getObjectStation(int number);
        public abstract int getNumberStation(String name);
        public static AStationManager createAStationManager()
        { 
            return new StationManager();
        }
        public static AStationManager createAStationManager(List<DataStation> dataStations)
        {
            return new StationManager(dataStations);
        }
        public abstract int stationCount();
        public abstract void realization(string[] lol, int number);
      

    }
}
