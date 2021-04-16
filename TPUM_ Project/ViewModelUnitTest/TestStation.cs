using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelUnitTest
{
    internal class TestStation : IStation
    {
        public TestStation()
        {
        }

        public TestStation(String name)
        {
            this.Name = name;
        }
        public override void cyclicalUpdateTemperature()
        {
            throw new NotImplementedException();
        }

        public override float getTemperatureFromSensor()
        {
            throw new NotImplementedException();
        }
        public static ObservableCollection<IStation> generateStations(int i)
        {
            ObservableCollection<IStation> stations = new ObservableCollection<IStation>();

            for (int j = 0; j < i; j++)
            {
                stations.Add(new TestStation());
            }
            return stations;
        }

    }
}
