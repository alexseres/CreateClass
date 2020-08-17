using System;

namespace CreateClass
{
    public class Employee : Person
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession, Room room) : base(name, birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
            Room = room;
        }

        public Room Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }

        public int Salary
        {
            get => salary;
            set => salary = value;
        }

        public string Profession
        {
            get => profession;
            set => profession = value;
        }


        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}, {nameof(Profession)}: {Profession}, {nameof(Room)} number: {Room.RoomNumber}";
        }
    }
}