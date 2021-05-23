using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class AStationManager: INotifyPropertyChanged
    {
       
        protected DataManager dataManager;
        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        public static AStationManager createAStationManager()
        { 
            
            return new StationManager();
        }
        public abstract  int getMaxTemp();
        public string[] getStation()
        {
                string[] station = new string[3];
            if(WebSocketManager.dataManager.DataStation!= null)
            {
                station[0] = WebSocketManager.dataManager.DataStation.Name;
                station[1] = WebSocketManager.dataManager.DataStation.NowTemp.ToString() ;
                station[2] = WebSocketManager.dataManager.DataStation.TargetTemp.ToString();
                return station;
            }
            else
            {
                station[0] = "___________";
                station[1] = "0";
                station[2] = "0";
            
                return station;
            }
            
        }
        public string[] updateStation(float xd)
        {
            string[] station = new string[4];
            if (WebSocketManager.dataManager.DataStation != null)
            {
                
                station[0] = WebSocketManager.dataManager.DataStation.Name;
                station[1] = WebSocketManager.dataManager.DataStation.NowTemp.ToString();
                station[2] = WebSocketManager.dataManager.DataStation.TargetTemp.ToString();
                station[3] = WebSocketManager.dataManager.MaxHeat.ToString();
                return station;
            }
            return null;
        }
        public abstract void IncreaseTargetTemp();
        public abstract void DeleteStation();
        public abstract void AddStation(string name);
        public abstract void getPreviousStation();
        public abstract void IncreaseMaxTemp();
        public abstract void getNextStation();
        public abstract void DecreaseMaxTemp();
        public abstract void DecreaseTargetTemp();
      
    }
}
