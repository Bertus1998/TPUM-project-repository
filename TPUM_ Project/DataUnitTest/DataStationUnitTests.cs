using System;
using System.Collections.Generic;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataUnitTest
{
    [TestClass]
    public class DataStationUnitTests
    {
        [TestMethod]
        public void GetStationTest()
        {
            //Arrange
            int count = 10;
            //Act  
            List<DataStation> dataStations = DataStation.GetStations(count);
            //Assert
            Assert.AreEqual(dataStations.Count, count);
        }
        [TestMethod]
        public void createStationTest()
        {
            //Arrange
            String name = "Station";
            //Act
           DataStation data = DataStation.createStation(name);
            //Assert
            Assert.AreEqual(data.Name, name);
        }
        [TestMethod]
        public void simulateTempTest()
        {
            //Arrange
            int maxTemp1 = 30;
            int maxTemp2 = 15;
            DataStation dataStation1 = DataStation.createStation("testName1");
            DataStation dataStation2 = DataStation.createStation("testName2");
            var excpected1 = dataStation1.TargetTemp;
            var excpected2 = maxTemp2;

            //Act

            dataStation1.simulateTemp(maxTemp1);
            dataStation2.simulateTemp(maxTemp2);
            //Assert
            Assert.AreEqual(maxTemp2, excpected2);
            Assert.AreEqual(dataStation1.TargetTemp, excpected1);

        }
    }
}
