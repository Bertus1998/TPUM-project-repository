using System;
using System.ComponentModel;
using System.Threading;


namespace Model
{
     public class Station : IStation
    {
          public Station(String name)
        {
            _Sensor = new DS18B20();
            new Thread(delegate () { cyclicalUpdateTemperature(); }).Start();
            TargetTemp = 20f;
            NowTemp = 20f;
            Name = name;
           
        }

        public override void cyclicalUpdateTemperature()
        {
            while(true)
            {
                Thread.Sleep(1000);
                simulateTemp();
              
                // NowTemp = getTemperatureFromSensor();
            }
        }

        public override float getTemperatureFromSensor()
        {
            
            return _Sensor.getData();
        }
        public void simulateTemp()
        {
            if (Heat)
            {
                NowTemp += 0.1f;
            }
            else
            {
                NowTemp -= 0.1f;
            }
        }
    }
}
