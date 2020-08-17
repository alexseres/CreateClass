using System;
using System.Collections.Generic;

namespace CreateClass
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Aggregator aggregator = new Aggregator();
             
            Person Alex = new Person("Alex", DateTime.Parse("1995-04-20"), Person.Gender.MALE );
            Console.WriteLine(Alex.ToString());
            Room room = new Room(1);
            Employee employee1 = new Employee("Sanyi",DateTime.Parse("1984-11-12"),Person.Gender.MALE,200,"Chef", room);
            Employee employee2 = new Employee("Adesz",DateTime.Parse("1905-1-23"),Person.Gender.FEMALE,333,"Tailor",room );
            Employee employee3 = new Employee("Sanyi", DateTime.Parse("1990-08-29"), Person.Gender.MALE, 500, "Programmer", room );
            aggregator.AddToEmployyes(employee1);
            aggregator.AddToEmployyes(employee2);
            aggregator.AddToEmployyes(employee3);
            int allEmployeeSalary = aggregator.getAllPerson(aggregator.Employees);
            
            
            
            //exercise 3
            Employee employee4 = new Employee("Josi Bharat",DateTime.Parse("1919-11-12"),Person.Gender.MALE,1111,"Baker", room);
            Employee employee4Clone = (Employee) employee4.Clone();
            Console.WriteLine(employee4.ToString());
            
            
            
            Console.WriteLine(employee1.ToString());
            Console.ReadKey();
        }
        

        
    }
}