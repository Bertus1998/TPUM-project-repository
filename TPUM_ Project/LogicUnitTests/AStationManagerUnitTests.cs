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

    }
}
