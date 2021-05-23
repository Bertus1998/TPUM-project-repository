
using Logic_Server;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Komunikacja
{
    class CommunicationManager
    {
        
        public static int _port = 8007;
        public static List<WebSocketConnection> listOfWebscoketConnection = new List<WebSocketConnection>();
        public static Dictionary<WebSocketConnection, int> map = new Dictionary<WebSocketConnection, int>();
        internal static void toLogic(string[] lol, int number)
        {
            stationManager.realization(lol, number);
        }
        public static Uri m_clientURI = new Uri("http://localhost:8007/ws/");
        public static AStationManager stationManager = AStationManager.createAStationManager();
        static async Task Main(string[] args)
        {          
            await WebSocketServer.Server(_port, async client => {
           
                int x = listOfWebscoketConnection.Count;
                listOfWebscoketConnection.Add(client);
                map.Add(client, 0);
                await client.SendAsync(JsonSerializer.Serialize(stationManager.getStation(0)));
                Console.WriteLine("Server connected ...");
                reactiveProgramming();
            });
            
        }
        public static async void reactiveProgramming()
        {
            string[] maxHeat = new string[2];
            maxHeat[0] = "MaxHeat";
            while (true)
            {
                foreach (WebSocketConnection webSocketConnection in listOfWebscoketConnection)
                {
                    
                    int x;
                    if(map.TryGetValue(webSocketConnection, out x))
                    {
                        
                        Console.WriteLine(x);
                        await webSocketConnection.SendAsync(JsonSerializer.Serialize(stationManager.getStation(x)));
                        
                        maxHeat[1] = stationManager.MaxHeat.ToString();
                        await webSocketConnection.SendAsync(JsonSerializer.Serialize(maxHeat));

                    }
                }
                Thread.Sleep(1000);
            }
        }
        public static string[] deserializationOfMessage(string x)
        {
          return  JsonSerializer.Deserialize<string[]>(x);
        }
        public static int findNumberOfStation(string name)
        {
           int i = stationManager.getNumberStation(name);
           return i;
        }
      
       
    }
}
