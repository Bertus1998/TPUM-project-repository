using System;
using System.ComponentModel;
using System.Threading;


namespace Model
{
    public class Station : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        Sensor sensor;
        private bool heat;
        private string name;
        private volatile float nowTemp;
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
        public float NowTemp
        {
            get { return nowTemp; }
            set {
                if (NowTemp > TargetTemp)
                {
                    Heat = false;
                }
                else
                {
                    Heat = true;
                }
                nowTemp = value;

                PropertyChanged(this, new PropertyChangedEventArgs("NowTemp"));
            }
        }
        public float TargetTemp
        {
            get { return targetTemp; }
            set {
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Station(String name)
        {
            this.sensor = new DS18B20();
            Name = name;
            this.nowTemp = 20f;
            this.targetTemp = 20f;
            new Thread(delegate () { getData();}).Start();
        }
          private void getData()
          {

              while (true)
              {
                Thread.Sleep(200);
                nowTemp = sensor.getData();
              }
          }
      
        
    }
}
