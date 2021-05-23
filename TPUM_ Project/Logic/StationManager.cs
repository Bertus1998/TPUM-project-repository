using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    internal class StationManager: AStationManager, INotifyPropertyChanged
    {
        protected DataStation dataStation;
        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        public DataStation DataStation
        {
            get { return dataStation; }
            set { dataStation = value;
                PropertyChanged(this, new PropertyChangedEventArgs("DataStation"));
            }
        }
        public StationManager()
        {
          
            dataManager = new DataManager();
        }

        public override int getMaxTemp()
        {
            return dataManager.MaxHeat;
        }

        public override void IncreaseTargetTemp()
        {
            dataManager.increaseTargetTempAsync();

        }

        public override void DeleteStation()
        {
            dataManager.deleteStationAsync();
        }

        public override void AddStation(string name)
        {
            dataManager.AddStationAsync(name);
        }

        public override void getPreviousStation()
        {
          dataManager.getPreviousStationAsync();
        }

        public override void IncreaseMaxTemp()
        {
            dataManager.IncreseMaxTempAsync();
        }

        public override void getNextStation()
        {
            dataManager.getNextStationAsync();
        }

        public override void DecreaseMaxTemp()
        {
            
            dataManager.decreaseMaxTempAsync();
        }

        public override void DecreaseTargetTemp()
        {
           
            dataManager.decreaseTargetTempAsync();
        }
    }
}
