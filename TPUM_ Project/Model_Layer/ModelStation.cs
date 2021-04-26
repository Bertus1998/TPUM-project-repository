using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class ModelStation: INotifyPropertyChanged
    {
        private int position;
        Thread thread;
        public int Position
        {
            get { return position; }
            set
            {
                string[] xd = this.StationManager.getStation(position);
                station = IStation.createStation(Int32.Parse(xd[2]), Int32.Parse(xd[1]), xd[0]);
                position = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Position"));
            }
        }
        private int maxHeat;
        public int MaxHeat
        {
            get { return maxHeat; }
            set { maxHeat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MaxHeat"));
            }
        }
        private AStationManager StationManager;
        private IStation station;
        public IStation Station
        {
            get { return station; }
            set { station = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Station"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
       
        public ModelStation()
        {
            this.position = 0;
            this.StationManager = AStationManager.createAStationManager();
            string[] xd = this.StationManager.getStation(position);
            this.MaxHeat = this.StationManager.MaxHeat;
            station = IStation.createStation(float.Parse( xd[2]), float.Parse(xd[1]), xd[0]);
            Thread thread = new Thread(() => actualizeNowTemp());
            thread.Start();
        }
        public void decreaseTemp()
        {
            StationManager.DecreaseTargetTemp(position);
            string[] elements = StationManager.getStation(position);
            Station = IStation.createStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
        }
        public void increaseTemp()
        {
            StationManager.IncreaseTargetTemp(position);
            string[] elements = StationManager.getStation(position);
            Station = IStation.createStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
        }
        public void removeStation()
        {
            StationManager.DeleteStation(position);
            previousStation();
        }
        public void addStation(String name)
        {
            
            StationManager.AddStation( name);
            string[] elements = StationManager.getStation(StationManager.stationCount()-1);
            position = StationManager.stationCount() - 1;
            Station = IStation.createStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
        }
        public void increaseMaxTemp()
        {
            StationManager.IncreaseMaxTemp();
            this.MaxHeat = StationManager.MaxHeat;
        }
        public void deacreaseMaxTemp()
        {
            StationManager.DecreaseMaxTemp();
            this.MaxHeat = StationManager.MaxHeat;
        }
        public void nextStation()
        {
            position += 1;
            if (position > StationManager.stationCount() - 1)
            {
                position = 0;
            }
            string[] elements = StationManager.getStation(position);
            if (elements == null)
            {
                Station = null;
            }
            else
            {
                Station = IStation.createStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
            }
      
        }
        public void previousStation()
        {
            position -= 1;       
          if(position < 0)
            {
                position = StationManager.stationCount()-1;   
            }
            string[] elements = StationManager.getStation(position);
            if(elements==null)
            {
                Station = null;
            }
            else
            {
                Station = IStation.createStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
              
            }
           
        }
        public void actualizeNowTemp()
        {
            while(true)
            {
                Thread.Sleep(1000);
            string[] elements = StationManager.getStation(position);
            if (elements == null)
               {
                   Station = null;
             }
             else
                {
                Station = IStation.createStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);              
              }
            }
        }
        
    }
}
 