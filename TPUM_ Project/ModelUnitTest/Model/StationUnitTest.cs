using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
namespace ModelUnitTest.Model
{
    [TestClass]
    public class StationUnitTest
    {
        [TestMethod]
        public void simulateTemp()
        {

            //Arrange
            Station station1 = new Station("1");
            Station station2 = new Station("2");
            station1.Heat = true;
            station2.Heat = false;
            var expected1 = station1.NowTemp + 0.1f;
            var expected2 = station2.NowTemp - 0.1f;
            //Act
            station1.simulateTemp();
            station2.simulateTemp();
            var actual1 = station1.NowTemp;
            var actual2 = station2.NowTemp;
            //Assert
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);

        }
    }
}
