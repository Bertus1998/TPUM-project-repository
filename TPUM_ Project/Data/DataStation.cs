using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class DataStation : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        private bool heat;
        private string name;
        public bool Heat
        {
            get { return heat; }
            set
            {
                heat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Heat"));

            }
        }

     
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public float TargetTemp
        {
            get { return targetTemp; }
            set
            {
                if (TargetTemp > NowTemp)
                {
                    heat = true;
                }
                else
                {
                    heat = false;
                }
                targetTemp = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TargetTemp"));

            }
        }
        private float targetTemp;
        public float NowTemp
        {
            get { return nowTemp; 
            }
            set
            {
                if (NowTemp > TargetTemp)
                {
                    heat = false;
                }
                else
                {
                    heat = true;
                }
                nowTemp = value;
                PropertyChanged(this, new PropertyChangedEventArgs("NowTemp"));
            }
        }
        private float nowTemp;
     
    
     
    }
}
