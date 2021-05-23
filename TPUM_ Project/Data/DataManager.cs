using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data
{
    public class DataManager : INotifyPropertyChanged
    {
        private DataStation dataStation;


        private int maxHeat = 35;
        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        public int MaxHeat
        {
            get { return maxHeat; }
            set { maxHeat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MaxHeat"));
            }
            
        }
      public DataStation DataStation
        {
            get { return dataStation; }
            set { dataStation = value;
                PropertyChanged(this, new PropertyChangedEventArgs("DataStation"));
            }
        }

        public async Task deleteStationAsync()
        {
            string[] xd = new string[1];
            xd[0] = "Delete";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }

        public async Task AddStationAsync(string name)
        {
            string[] xd = new string[2];
            xd[0] = "Add";
            xd[1] = name;
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }

        public async Task getPreviousStationAsync()
        {
            string[] xd = new string[1];
            xd[0] = "previous";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }

        public async Task IncreaseTargetTempAsync()
        {
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(dataStation));
        }

        public async Task getNextStationAsync()
        {
            string[] xd = new string[1];
            xd[0] = "next";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }
        public DataManager()
        {
            this.DataStation = new Station("HAHAA");
            WebSocketManager.configuer();
        }

        public async Task IncreseMaxTempAsync()
        {
            string[] xd = new string[1];
            xd[0] = "increaseMaxTemp";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }

        public async Task decreaseMaxTempAsync()
        {
            string[] xd = new string[1];
            xd[0] = "decreaseMaxTemp";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));

        }

        public async Task decreaseTargetTempAsync()
        {
            string[] xd = new string[1];
            xd[0] = "decreaseTargetTemp";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }
        public async Task increaseTargetTempAsync()
        {
            string[] xd = new string[1];
            xd[0] = "increseTargetTemp";
            await WebSocketManager.webSocketConnection.SendAsync(JsonSerializer.Serialize(xd));
        }
    }
}
