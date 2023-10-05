using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    public class TripTests
    {
        [TestMethod]

        public void Test_Cost_Per_Mile()
        {
            Trip myTrip = new Trip("Grand Canyon", 1200, 120M, 40);//objekt myTrip sa vrijednoscu destination Grand Canyon
            string mojaDestinacija = myTrip.Destination.ToString();
            mojaDestinacija = "Govnetaro od govnetaaaaa i jedem pastetu";
            Console.WriteLine(myTrip.CostPerMile());
        }

        [TestMethod]

        public void Test_Miles_Per_Gallon()
        {
            Trip myTrip = new Trip("Grand Canyon", 1200, 120M, 40);
            Console.WriteLine(myTrip);
        }

        [TestMethod]
        public void Test_ToString()
        {
            Trip myTrip = new Trip("Grand Canyon", 1200, 120M, 40);
            Console.WriteLine(myTrip);
        }
    }
}

