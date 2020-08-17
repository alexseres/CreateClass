using System;
using CreateClass;
using NUnit.Framework;

namespace CreateClassTests1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Aggregator aggregator = new Aggregator();
            Employee employee1 = new Employee("Sanyi",DateTime.Parse("1984-11-12"),Person.Gender.MALE,200,"Chef", null);
            Employee employee2 = new Employee("Adesz",DateTime.Parse("1905-1-23"),Person.Gender.FEMALE,333,"Tailor",null);
            Employee employee3 = new Employee("Sanyi", DateTime.Parse("1990-08-29"), Person.Gender.MALE, 500, "Programmer", null );
            aggregator.AddToEmployyes(employee1);
            aggregator.AddToEmployyes(employee2);
            aggregator.AddToEmployyes(employee3);
            int actual = aggregator.getAllPerson(aggregator.Employees);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}
