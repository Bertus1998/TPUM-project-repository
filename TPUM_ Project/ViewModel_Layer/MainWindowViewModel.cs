

using Model;
using System;
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
        public  ModelStation model;
   
        public MainWindowViewModel()
        {
            this.model =  new ModelStation();               
            setICommand();
        }
        public void setICommand()
        {
            AddStation = new AddStationCommand(this);
            IncreaseTemp = new IncreaseTemperatureCommand(this);
            DecreaseTemp = new DecreaseTemperatureCommand(this);
            RemoveStation = new RemoveCommand(this);
            DecreaseMaxTemp = new DecreaseMaxTemp(this);
            IncreaseMaxTemp = new IncreaseMaxTemp(this);
            NextStation = new NextStationCommand(this);
            PreviousStation = new PreviousStationCommand(this);
        }
        public ModelStation Model
        {
            get { return model; }
            set { model = value; }
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
        public ICommand PreviousStation { get; private set; }
        public ICommand NextStation { get; private set; }

    }
}
