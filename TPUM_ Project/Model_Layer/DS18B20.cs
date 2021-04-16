using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Model
{
    class DS18B20 : Sensor
    {
       
        public float CurrentTemp {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        public override float getData()
        {
            //way to get temp from sensor
            return currentTemp;
        }

        public DS18B20()
        {
            currentTemp = 0;
        }
    }
}
