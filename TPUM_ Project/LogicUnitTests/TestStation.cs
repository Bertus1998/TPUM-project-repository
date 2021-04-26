using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnitTests
{
    class TestStation : DataStation
    {
        public override void simulateTemp(int MaxHeat)
        {
            throw new NotImplementedException();
        }
        TestStation(String name)
        {
            this.Name = name;
        }
        public TestStation(float targetTemp, float currentTemp, String name)
        {
            this.Name = name;
            this.TargetTemp = targetTemp;
            this.NowTemp = currentTemp;
        }
        static List<DataStation> depenedenyInject(int number)
        {
            List<DataStation> dataStations = new List<DataStation>();
            for(int i =0; i <number;i++)
            {
                dataStations.Add(new TestStation(i.ToString()));
            }
            return dataStations;
        }
    }
}
