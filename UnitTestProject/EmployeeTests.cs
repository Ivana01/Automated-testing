using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section6
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Test_Employee_ID_Set()
        {
            Employee employee1 = new Employee(123);

            employee1.JobTitle = "Manager";
            employee1.EmployeeID = 1;
            string jobLocation = employee1.JobLocation();
            StringAssert.Equals(jobLocation, "New York");
        }

        [TestMethod]
        public void To_String_Test()
        {
            Employee employee1 = new Employee("Sara Burke", 123, "Manager");
            Console.WriteLine(employee1);
        }
    }
}
