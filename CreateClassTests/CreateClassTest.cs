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
                
            int res = aggregator.getAllPersonSalary(aggregator.Employees);
            Assert.AreEqual(res,3);
        }
    }
}
}