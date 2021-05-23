using Data_Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Logic_Unit_Tests
{
    class TestStation : DataStation
    {

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
            for (int i = 0; i < number; i++)
            {
                dataStations.Add(new TestStation(i.ToString()));
            }
            return dataStations;
        }

        public override void simulateTemp(int MaxHeat)
        {
            throw new NotImplementedException();
        }
    }
}
