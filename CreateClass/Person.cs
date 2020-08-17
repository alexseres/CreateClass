using System;

namespace CreateClass
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private Gender _gender;


        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            _gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
        
        public enum Gender

        {
            MALE,
            FEMALE
        }


        public override string ToString()
        {
            return $"{nameof(_gender)}: {_gender}, {nameof(Name)}: {Name}, {nameof(BirthDate)}: {BirthDate}";
        }
    }
}