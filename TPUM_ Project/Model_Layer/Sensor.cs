using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Sensor
    {
        protected float currentTemp;
        public abstract float getData();
    }
}
