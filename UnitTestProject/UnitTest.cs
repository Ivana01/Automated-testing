using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("LoginFeature")]
    public class UnitTest
    {
        [TestMethod]
        [Description("these are demo unit tests")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 1;
            Assert.AreNotEqual(1, a);
        }
    }
    [TestClass]
    [TestCategory("Quiz")]
    public class Test2
    {
        [TestMethod]
        [Description("assertions and attributes tests")]
        public void TestMethod()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This test will always fail");
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
namespace Part3
{
    [TestClass]
    [TestCategory("Part3")]
    public class Test3
    {
        private int a;
        public TestContext TestContext { get; set; }
        private static TestContext _testContext;
        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            this.TestContext = TestContext;
            a = 1;
        }

        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single test method in a class");
        }
        [ClassInitialize]
        public static void RunBeforeAllOfTheTestMethodsStarted(TestContext testContext)
        {
            _testContext = testContext;
            Trace.Write("I will run one time before all the tests in the class started");
        }
        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.Write("I will run one time after all the tests in the class finished");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Trace.Write(TestContext.TestName);
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(1, a);
        }
    }
}


namespace Section6
{
    [TestClass]
    public class IntegerOperations
    {
        //variables to hold the two integer values
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {

            //set the values of the two numbers we will be using 

            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            int difference = number1 - number2;
            Assert.AreEqual(difference, 5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int product = number1 * number2;
            Assert.AreEqual(product, 50);
        }

        [TestMethod]
        public void Test_Division()
        {
            int quotient = number1 / number2;
            Assert.AreEqual(quotient, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int remainder = number1 % number2;
            Assert.AreEqual(remainder, 0);
        }
    }
    [TestClass]
    public class FloatingPointOperations
    {
        //variables to hold the two double values
        static double number1;
        static double number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we will be using
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Addition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5);
        }
    }

    [TestClass]
    public class DecimalOperations
    {
        //variables to hold the two double values
        static decimal number1;
        static decimal number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext textContext)
        {
            //set the values of the two numbers we will be using 
            number1 = 10.5M;
            number2 = 5.0M;
        }

        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5M);
        }

    }

    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            double celsius;
            double fahrenheit = 57;
            celsius = (fahrenheit - 32) * .5556;
            Console.WriteLine($"The temp in F {fahrenheit} is {celsius} in C");
            Assert.AreEqual(celsius, 13.89, 0.001);
        }


        [TestMethod]
        public void Convert_C_To_F()
        {
            double celsius = 12.5;
            double fahrenheit;
            fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"The temp in C {celsius} is {fahrenheit} in F");
            //Assert.AreEqual(fahrenheit, 54.5);
        }


        [TestClass]
        public class EqualityAndRelationship
        {
            static int number1;
            static int number2;

            [ClassInitialize()]
            public static void IntegerInitialize(TestContext textContext)
            {
                //set the values of the two numbers we will be using 
                number1 = 10;
                number2 = 5;
            }

            [TestMethod]
            public void Number1_Is_Equal_Number2()
            {
                Assert.IsTrue(number1 == number2);
            }

            [TestMethod]
            public void Number1_Is_Not_Equal_Number2()
            {
                if (number1 != number2)
                {
                    Assert.IsTrue(number1 != number2);
                }
            }

            [TestMethod]
            public void Number1_Greater_Than_Number2()
            {
                if (number1 > number2)
                {
                    //this code is executed if the if statement is true 
                    Assert.IsTrue(number1 > number2);
                }
                else
                {
                    //this code is executed if the if statement is false
                    Assert.Fail();
                }
            }

        }
    }
}


namespace Section6
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Class()
        {
            string str = "Last night";
            Console.WriteLine(str);
            string substr = str.Substring(2);
            Console.WriteLine(substr);

        }

        [TestMethod]
        public void Joining_Strings_Together()
        {
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            string name = new string(chars);
            Console.WriteLine(name);
        }
    }
}






