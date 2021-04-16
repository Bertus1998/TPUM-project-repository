

using System;

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;
using ViewModel.Commands;

namespace ViewModel
{
    public class MainWindowViewModel : INotifyCollectionChanged, INotifyPropertyChanged
    {
        
       
        public event NotifyCollectionChangedEventHandler CollectionChanged = (IChannelSender, e) => { };
        public event PropertyChangedEventHandler PropertyChanged = (IChannelSender, e) => { };
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindowViewModel()//ObservableCollection<Station> stations)
        {
            //listOfStations = stations;
            this.maxHeat = 35;
         //   new Thread(delegate () { monitorHeatSystem(stations); }).Start();
            /*for(int i =0;i<5;i++)
             {
                 Station temp = new Station(i.ToString());
                 listOfStations.Add(temp);
                 new Thread(delegate () { simulateHeatSystem(temp); }).Start();

             }*/
            AddStation = new AddStationCommand(this);
            IncreaseTemp = new IncreaseTemperatureCommand(this);
            DecreaseTemp = new DecreaseTemperatureCommand(this);
            RemoveStation = new RemoveCommand(this);
            DecreaseMaxTemp = new DecreaseMaxTemp(this);
            IncreaseMaxTemp = new IncreaseMaxTemp(this);
        }
        /// <summary>
        /// Properties
        /// </summary>
        private ObservableCollection<Model.Station> listOfStations = new ObservableCollection<Model.Station>();
        private float maxHeat;
        /// <summary>
        /// Accesors
        /// </summary>
        public ObservableCollection<Model.Station> ListOfStations
        {
            get { return listOfStations; }
            set { listOfStations = value; }
        }
        public float MaxHeat
        {
            get { return maxHeat; }
            set
            {
                maxHeat = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MaxHeat"));
            }
        }

        /// <summary>
        /// ICommands
        /// </summary>
        public ICommand IncreaseTemp { get; private set; }
        public ICommand DecreaseTemp { get; private set; }
        public ICommand AddStation { get; private set; }
        public ICommand RemoveStation { get; private set; }
        public ICommand IncreaseMaxTemp { get; private set; }
        public ICommand DecreaseMaxTemp { get; private set; }
        /// <summary>
        /// Execute function
        /// </summary>
        /// <param name="obj"></param>
        public void OnExecuteIncrease(Object obj)
        {
            if (obj != null)
            {

                ((Model.Station)obj).TargetTemp += 1;

            }
            return;
        }
        public void OnExecuteAddStation(Object obj)
        {
            if (obj != null && !((String)obj).Equals(""))
            {
                foreach (Model.Station station in ListOfStations)
                {
                    if (((String)obj).Equals(station.Name))
                    {
                        return;
                    }
                }
                Model.Station temp = new Model.Station(obj.ToString());
                listOfStations.Add(temp);
                // new Thread(delegate () { simulateHeatSystem(temp); }).Start();
            }

        }
        public void OnExecuteDecrease(Object obj)
        {
            if (obj != null)
            {
                ((Model.Station)obj).TargetTemp -= 1;
            }
            return;
        }
        public void OnExecuteRemoveStation(Object obj)
        {
            if (obj != null)
            {
                listOfStations.Remove((Model.Station)obj);
            }
        }
        public void OnExecuteIncreaseMax()
        {
            MaxHeat += 1;

        }
        public void OnExecuteDecreaseMax()
        {
            MaxHeat -= 1;
        }
        /// <summary>
        /// Observe heat system
        /// </summary>
        /// <param name="stations"></param>
        public void monitorHeatSystem(ObservableCollection<Model.Station> stations)
        {

            while (true)
            {
                foreach (Model.Station station in stations)
                {
                    if (station.NowTemp > MaxHeat + 0.1&&station.Heat)
                    {
                        station.Heat = false;
                        station.TargetTemp = MaxHeat;
                    }
                }
            }
            /*  public void simulateHeatSystem(Station station)
              {
                  while (true)
                  {

                      Thread.Sleep(200);
                      if(station.NowTemp>MaxHeat+0.1)
                      {
                          MessageBox.Show(station.Name + "overheat");
                          station.Heat = false;
                          station.TargetTemp = MaxHeat;
                          while (station.NowTemp>MaxHeat)
                          {
                              station.NowTemp -= 0.01f;
                              Thread.Sleep(200);
                          }


                      }
                      if (station.Heat)
                      {
                          station.NowTemp += 0.01f;
                      }
                      else
                      {
                          station.NowTemp -= 0.01f;

                      }

                  }

              }
              */

        }
        
    }
}
