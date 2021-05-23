using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace Data
{
    public class WebSocketManager: INotifyPropertyChanged
    {

        public static DataManager dataManager = new DataManager();
      

        public static Uri uri = new Uri("ws://localhost:8007/ws/");
        public static  WebSocketConnection webSocketConnection = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public static async Task ConnectAsync(Uri peer, Action<WebSocketConnection> onOpen, Action<string> log)
        {  
            var task =  WebSocketClient.Connect(peer, onOpen, log);
            WebSocketManager.webSocketConnection =  await task;
        }
        public static void configuer()
        {
            bool _onClose = false;
            List<string> _Log = new List<string>();
            WebSocketManager.ConnectAsync(uri, x => webSocketConnection = x, message => _Log.Add(message));
        }
        internal static void realize(string x)
        {
            string[] message =  JsonSerializer.Deserialize<string[]>(x);
           

            if (message.Length == 3)
            {

                float x1, x2;
                bool xd = float.TryParse(message[1], out x1);
                bool xd1 = float.TryParse(message[2], out x2);
                if (xd&&xd1)
                {
                    dataManager.DataStation = new Station(message[0], x1, x2);
                }
            }
           
            else if (message.Length == 1)
            {
                dataManager.DataStation.NowTemp = float.Parse(message[0]);
            }
            else if (message.Length == 2)
            {
                if(message[0] == "MaxHeat")
                {
                    dataManager.MaxHeat = int.Parse(message[1]);
                }
            }

        }
    }
}
