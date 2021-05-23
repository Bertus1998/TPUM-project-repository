using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Komunikacja
{
        public abstract class WebSocketConnection
        {
            public virtual async Task<Action<string>> onMessageAsync(string x)
              {
 
                string[] lol = CommunicationManager.deserializationOfMessage(x);
                 Console.WriteLine(lol[0]);
                int number = CommunicationManager.findNumberOfStation(lol[0]);
            if (lol[0] == "previous")
            {


                if ((CommunicationManager.map[this] = CommunicationManager.map[this] - 1) >= 0)
                {
                    await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));
                }
                else
                {

                    CommunicationManager.map[this] = CommunicationManager.stationManager.stationCount() - 1;
                    await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));

                }
                Console.WriteLine(CommunicationManager.map[this]);


            }
            else if (lol[0] == "next")
            {
                if ((CommunicationManager.map[this] = CommunicationManager.map[this] + 1) < CommunicationManager.stationManager.stationCount())
                {
                    await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));
                }
                else
                {

                    CommunicationManager.map[this] = 0;
                    await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));

                }

                Console.WriteLine(CommunicationManager.map[this]);
            }
            else if (lol[0] == "Add")
            {
                CommunicationManager.stationManager.AddStation(lol[1]);
                CommunicationManager.map[this] = CommunicationManager.stationManager.getNumberStation(lol[1]);
                await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));
            }
            else if (lol[0] == "Delete")
            {
                CommunicationManager.stationManager.DeleteStation(CommunicationManager.map[this]);
                CommunicationManager.map[this] = 0;
                await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));
            }
            else if (lol[0] == "increaseMaxTemp")
            {
                CommunicationManager.stationManager.IncreaseMaxTemp();             
                await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));

            }
            else if (lol[0] == "decreaseMaxTemp")
            {
                CommunicationManager.stationManager.DecreaseMaxTemp();               
                await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));

            }
            else if (lol[0] == "increseTargetTemp")
            {
                CommunicationManager.stationManager.IncreaseTargetTemp(CommunicationManager.map[this]);               
                await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));

            }
            else if (lol[0] == "decreaseTargetTemp")
            {
                CommunicationManager.stationManager.DecreaseTargetTemp(CommunicationManager.map[this]);            
                await this.SendAsync(JsonSerializer.Serialize(CommunicationManager.stationManager.getStation(CommunicationManager.map[this])));
            }
            else
            {
                CommunicationManager.toLogic(lol, number);
            }
             return null;
            }
          
            public virtual Action onClose { set; protected get; } = () => {
                
            
                Console.WriteLine("Disconnected"); };
            public virtual Action onError { set; protected get; } = () => { Console.WriteLine("Error"); };

            public async Task SendAsync(string message)
            {
   
                await SendTask(message);
            }

            public abstract Task DisconnectAsync();

            protected abstract Task SendTask(string message);
        }
    
}
