using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]

    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange
            Car myCar = new Car("Red", 2, true);

            //act

            //assert
            StringAssert.Equals(myCar.Color, "Red");
            StringAssert.Equals(myCar.NumberOfDoors, 2);

        }

        [TestMethod]
        public void Call_Acceleration_Method()
        {
            Car myCar = new Car("Red", 2, true);

            //act
            myCar.Accelerate();
        }

        [TestMethod]
        public void Call_FamilyCar_Method()
        {
            Car myCar = new Car("Red", 2, true);

            //act
            bool carType = myCar.FamilyCar();

            //assert
            if (carType == true)
            {
                Assert.IsTrue(carType == true);
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}
