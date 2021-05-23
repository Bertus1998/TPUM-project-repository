using System;
using System.ComponentModel;
using System.Threading;


namespace Data_Server
{
      internal class Station : DataStation
    {
          public Station(String name)
        {
            TargetTemp = 20f;
            NowTemp = 20f;
            Name = name;          
        }
        public override void simulateTemp(int MaxTemp)
        {
            if(NowTemp>MaxTemp)
            {
                TargetTemp = MaxTemp;
            }
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
