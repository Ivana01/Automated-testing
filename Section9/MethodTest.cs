namespace Section9
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void Test_Square()
        {
            MethodTest myTest = new MethodTest();
            int result = myTest.Square(6);
            Assert.AreEqual(36, result);
        }

        public int Square(int aValue)
        {
            return aValue * aValue;
        }


    }
}
