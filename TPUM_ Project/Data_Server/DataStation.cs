using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Server
{
    public abstract class DataStation : INotifyPropertyChanged, IObservable<DataStation>
    {

        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
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
                if (NowTemp > TargetTemp)
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
        public abstract void simulateTemp(int MaxHeat);
        public static List<DataStation>  GetStations(int number)
         {
          List<DataStation> listStations = new List<DataStation>();
                   for(int i =0;i<number;i++)
                 {
                    listStations.Add(new Station(i.ToString()));
                  }
             return listStations;
        }
        public static  DataStation createStation(String name)
        {
            return new Station(name);
        }

        public IDisposable Subscribe(IObserver<DataStation> observer)
        {
            throw new NotImplementedException();
        }
    }
}
