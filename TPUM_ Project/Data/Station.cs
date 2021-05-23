using System;
using System.ComponentModel;
using System.Threading;


namespace Data
{
      internal class Station : DataStation
    {
          public Station(String name)
        {
            TargetTemp = 20f;
            NowTemp = 20f;
            Name = name;          
        }
        public Station(String name, float TargetTemp, float NowTemp)
        {
            this.TargetTemp = TargetTemp;
            this.NowTemp = NowTemp;
            this.Name = name;
        }
    }
}
