using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;
using ViewModel.Commands;

using ViewModel;

namespace ViewModelUnitTest.ViewModel
{
    [TestClass]
    public class ViewModelUnitTests
    {
        MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(TestStation.generateStations(5));
      
        [TestMethod]
        public void OnExecuteIncreaseUnitTest()
        {
            //Arrange
            TestStation testStation = (TestStation) this.mainWindowViewModel.ListOfStations[0];
            var excpected = testStation.TargetTemp+1;
            //Act
            mainWindowViewModel.OnExecuteIncrease(testStation);
            var actual = testStation.TargetTemp;
            //Assert
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void OnExecuteDecreaseUnitTest()
        {
            //Arrange
            TestStation testStation = (TestStation)this.mainWindowViewModel.ListOfStations[0];

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            var excpected = testStation.TargetTemp - 1;
            //Act
            mainWindowViewModel.OnExecuteDecrease(testStation);
            var actual = testStation.TargetTemp;
            //Assert
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        public void OnExecuteAddStationUnitTest()
        {
            //Arrange
            TestStation testStation = new TestStation("XD");
            var countExcepted = mainWindowViewModel.ListOfStations.Count + 1;
            //Act
            mainWindowViewModel.OnExecuteAddStation("XD");
            var countActual = mainWindowViewModel.ListOfStations.Count;
            //Assert
            Assert.AreEqual(countActual, countExcepted);
            Assert.IsNotNull(mainWindowViewModel.ListOfStations.Contains(testStation));
        }
        [TestMethod]
        public void OnExecuteRemoveStationUnitTest()
        {
            //Arrange

            TestStation station = (TestStation)mainWindowViewModel.ListOfStations[0];
  
            var countExcepted = mainWindowViewModel.ListOfStations.Count - 1;
            //Act
            mainWindowViewModel.OnExecuteRemoveStation(station);
            var countActual = mainWindowViewModel.ListOfStations.Count;
            //Assert
            Assert.AreEqual(countActual, countExcepted);
            Assert.IsFalse(mainWindowViewModel.ListOfStations.Contains((TestStation)station));
        }
        [TestMethod]
        public void OnExecuteIncreaaseMaxUnitTest()
        {
            //Arrange
            var excpected = mainWindowViewModel.MaxHeat + 1;
            //Act
            mainWindowViewModel.OnExecuteIncreaseMax();
            var actual = mainWindowViewModel.MaxHeat;
            //Assert
            Assert.AreEqual(actual, excpected);
        }
        [TestMethod]
        public void OnExecuteDecreaseMaxUnitTest()
        {
            //Arrange
            var excpected = mainWindowViewModel.MaxHeat - 1;
            //Act
            mainWindowViewModel.OnExecuteDecreaseMax();
            var actual = mainWindowViewModel.MaxHeat;
            //Assert
            Assert.AreEqual(actual, excpected);
        }
        [TestMethod]
        public void CompareTempToMaxUnitTest()
        {
            //Arrange
            TestStation testStation1 = (TestStation)mainWindowViewModel.ListOfStations[0];
            TestStation testStation2 = (TestStation)mainWindowViewModel.ListOfStations[1];
            TestStation testStation3 = (TestStation)mainWindowViewModel.ListOfStations[2];
            testStation1.NowTemp = 39;
            testStation2.NowTemp = 40;
            testStation3.NowTemp = 41;
            mainWindowViewModel.MaxHeat = 40;
            //Act
            mainWindowViewModel.compareTempToMax(testStation1);
            mainWindowViewModel.compareTempToMax(testStation2);
            mainWindowViewModel.compareTempToMax(testStation3);
            //Test
            Assert.AreEqual(testStation1.TargetTemp, testStation1.TargetTemp);
            Assert.AreEqual(testStation2.TargetTemp, testStation2.TargetTemp);
            Assert.AreEqual(testStation3.TargetTemp, mainWindowViewModel.MaxHeat);


            Assert.IsTrue(testStation1.Heat);
            Assert.IsTrue(testStation2.Heat);
            Assert.IsFalse(testStation3.Heat);
            
            
        }

    }





   
}

