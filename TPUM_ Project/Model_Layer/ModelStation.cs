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
            this.StationManager = AStationManager.createAStationManager();
            string[] xd = this.StationManager.getStation();
            this.MaxHeat = this.StationManager.getMaxTemp();
            this.Station = IStation.createStation(int.Parse(xd[1]), int.Parse(xd[2]), xd[0]) ;
            (new Thread(() => {
                string[] b = new string[3];
                while (true)
                {
                    b = StationManager.updateStation(0);
                    this.Station = IStation.createStation(float.Parse(b[1]), float.Parse(b[2]), b[0]);
                    this.MaxHeat = int.Parse(b[3]);
                    
                                  
                }
            })).Start();
        }
        public void decreaseTemp()
        {
            StationManager.DecreaseTargetTemp();
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);

        }
        public void increaseTemp()
        {
            StationManager.IncreaseTargetTemp();
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);

        }
        public void removeStation()
        {
            StationManager.DeleteStation();
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);
        }
        public void addStation(String name)
        {
            
            StationManager.AddStation(name);
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);


        }
        public void increaseMaxTemp()
        {
            StationManager.IncreaseMaxTemp();
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);
        }
        public void deacreaseMaxTemp()
        {
            StationManager.DecreaseMaxTemp();
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);
        }
        public void nextStation()
        {
            StationManager.getNextStation();
            
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);
        }
        public void previousStation()
        {
            StationManager.getPreviousStation();
            Thread.Sleep(100);
            String[] xd = StationManager.getStation();
            this.Station = IStation.createStation(float.Parse(xd[2]), float.Parse(xd[1]), xd[0]);

        }       
    }
}
 