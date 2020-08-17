using System;

namespace CreateClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person Alex = new Person("Alex", DateTime.Parse("1995-04-20"),Person.Gender.MALE );
            Console.WriteLine(Alex.ToString());
        }
    }
}