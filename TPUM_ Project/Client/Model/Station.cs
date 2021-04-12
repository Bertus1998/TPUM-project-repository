using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class Station
    {
        private string name;
        public string Name
        {
            get
            { return name;}
            set
            { name = value;}
        }
        private float nowTemp;
        public float NowTemp
        {
            get { return nowTemp;}
            set { nowTemp = NowTemp;}
        }
        public float TargetTemp
        {
            get { return targetTemp;}
            set { targetTemp = TargetTemp;}
        }
        private float targetTemp;
        public  Station(String name)
        {
            Name = name;
            this.nowTemp = 0f;
            this.targetTemp = 0f;
        }
        
    }
}
