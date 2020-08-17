using System.Collections.Generic;

namespace CreateClass
{
    public class Aggregator
    {
        
        
        private HashSet<Employee> employees = new HashSet<Employee>();

        public HashSet<Employee> Employees => employees;

        public void AddToEmployyes(Employee employee)
        {
            employees.Add(employee);
        }
        public int getAllPerson(HashSet<Employee> employees)
        {
            
            int allPerson= 0;
            foreach (var employee  in employees)
            {
                allPerson++;
            }

            return allPerson;
            

        }
    }
}