

using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;
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
        public MainWindowViewModel()
        {
            ListOfStations = IStation.LoadStations(5);
            this.maxHeat = 35;
            foreach(IStation station in ListOfStations)
            {
                new Thread(delegate () { monitorHeatSystem(station); }).Start();
            }
              
            setICommand();
        }
        public MainWindowViewModel(ObservableCollection<IStation> ListOfStation)
        {
            this.ListOfStations = ListOfStation;
        }
        public void setICommand()
        {
            AddStation = new AddStationCommand(this);
            IncreaseTemp = new IncreaseTemperatureCommand(this);
            DecreaseTemp = new DecreaseTemperatureCommand(this);
            RemoveStation = new RemoveCommand(this);
            DecreaseMaxTemp = new DecreaseMaxTemp(this);
            IncreaseMaxTemp = new IncreaseMaxTemp(this);
        }
   
        public ObservableCollection<IStation> listOfStations;
        private float maxHeat;
        public ObservableCollection<IStation> ListOfStations
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

                ((IStation)obj).TargetTemp += 1;

            }
            return;
        }
        public void OnExecuteAddStation(Object obj)
        {
            if (obj != null && !((String)obj).Equals(""))
            {
                foreach (IStation station in ListOfStations)
                {
                    if (((String)obj).Equals(station.Name))
                    {
                        return;
                    }
                }
                IStation temp = IStation.setupStation((String)obj);
                new Thread(delegate () { monitorHeatSystem(temp); }).Start();
                listOfStations.Add(temp);

            
            }

        }
        public void OnExecuteDecrease(Object obj)
        {
            if (obj != null)
            {
                ((IStation)obj).TargetTemp -= 1;
            }
            return;
        }
        public void OnExecuteRemoveStation(Object obj)
        {
            if (obj != null)
            {
                listOfStations.Remove((IStation)obj);
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
        public void monitorHeatSystem(IStation station)
        {
            while (true)
            {
                compareTempToMax(station);

            }
        }
        public void compareTempToMax(IStation station)
        {
            if (station.NowTemp > MaxHeat + 0.1 && station.Heat)
            {
                station.Heat = false;
                station.TargetTemp = MaxHeat;
            }
        }
        
    }
}
