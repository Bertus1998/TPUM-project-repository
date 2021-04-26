using System;
using Data;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicUnitTests
{
    [TestClass]
    public class AStationManagerUnitTests
    {
        AStationManager stationManager = 
            AStationManager.createAStationManager(TestStation.GetStations(10));
        [TestMethod]
        public void AddStationTest()
        {
            String name1 = "1";
            String name2 = "x";

            int preview = stationManager.stationCount();
            stationManager.AddStation(name1);

            Assert.AreEqual(preview, stationManager.stationCount());
            stationManager.AddStation(name2);
            Assert.AreEqual(preview+1, stationManager.stationCount());
        }
        [TestMethod]
        public void DecreaseTargetTempTest()
        {
            String[] elements =    stationManager.getStation(0);
            DataStation dataStation1 = new TestStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
            stationManager.DecreaseTargetTemp(0);
            elements = stationManager.getStation(0);
            DataStation dataStation2 = new TestStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
            Assert.AreEqual(dataStation1.TargetTemp-1, dataStation2.TargetTemp);
        }
        [TestMethod]
        public void DeleteStationTest()
        {
            int nmb1 = 1;
            int nmb2 = stationManager.stationCount() + 2;

            int preview = stationManager.stationCount();
            stationManager.DeleteStation(nmb2);

            Assert.AreEqual(preview, stationManager.stationCount());
            stationManager.DeleteStation(nmb1);
            Assert.AreEqual(preview-1, stationManager.stationCount());
        }
        [TestMethod]
        public void IncreaseTargetTempTest()
        {
            String[] elements = stationManager.getStation(0);
            DataStation dataStation1 = new TestStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
            stationManager.IncreaseTargetTemp(0);
            elements = stationManager.getStation(0);
            DataStation dataStation2 = new TestStation(float.Parse(elements[2]), float.Parse(elements[1]), elements[0]);
            Assert.AreEqual(dataStation1.TargetTemp+1, dataStation2.TargetTemp);
        }
        [TestMethod]
        public void IncreaseMaxTest()
        {
            int excepted = stationManager.MaxHeat + 1;
            stationManager.IncreaseMaxTemp();
            Assert.AreEqual(excepted, stationManager.MaxHeat);
        }
        [TestMethod]
        public void DecreaseMaxTest()
        {
            int excepted = stationManager.MaxHeat - 1;
            stationManager.DecreaseMaxTemp();
            Assert.AreEqual(excepted, stationManager.MaxHeat);
        }
        [TestMethod]
        public void stationCountt()
        {
            int x = 10;
            AStationManager stm =
            AStationManager.createAStationManager(TestStation.GetStations(x));
            Assert.AreEqual(x, stm.stationCount());
        }

    }
}
