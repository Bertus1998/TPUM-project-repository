using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Station :IStation
    {
       public Station(float targetTemp, float currentTemp, String name)
        {
            this.Name = name;
            this.TargetTemp = targetTemp;
            this.NowTemp = currentTemp;
        }
    }
}
