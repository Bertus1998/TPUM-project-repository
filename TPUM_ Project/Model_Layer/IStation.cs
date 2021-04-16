using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class IStation: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        private Sensor sensor;
        public Sensor _Sensor { 
            get { return sensor; }
            set { sensor = value; }
        }
        private bool heat;
        private string name;
        public bool Heat
        {
            get { return heat; }
            set
            {
                heat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Heat"));

            }
        }
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public float TargetTemp
        {
            get { return targetTemp; }
            set
            {
                if (TargetTemp > NowTemp)
                {
                    heat = true;
                }
                else
                {
                    heat = false;
                }
                targetTemp = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TargetTemp"));

            }
        }
        private float targetTemp;
        public float NowTemp
        {
            get { return nowTemp; }
            set
            {
                if(NowTemp>TargetTemp)
                {
                    heat = false;
                }
                else
                {
                    heat = true;
                }
                nowTemp = value;
                PropertyChanged(this, new PropertyChangedEventArgs("NowTemp"));
            }
        }
        private float nowTemp;
        public abstract  float getTemperatureFromSensor();
        public abstract void cyclicalUpdateTemperature();
        public static IStation  setupStation(String name)
        {
            return new Station(name);
        }
        public static ObservableCollection<IStation> LoadStations(int x)
        {
            ObservableCollection<IStation> stations = new ObservableCollection<IStation>();
            for(int i =0;i<x;i++)
            {
                stations.Add(new Station(i.ToString()));
            }
            return stations;
        }
    }
}
