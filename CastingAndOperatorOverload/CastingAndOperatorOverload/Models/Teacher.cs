using System;
using System.Collections.Generic;
using System.Text;

namespace CastingAndOperatorOverload.Models
{
    class Teacher:Person
    {

        //ctor
        public Teacher(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
        public Teacher(string name, string surname, int salary, int age) : this(name, surname, salary)
        {
            Age = age;
        }


        //field
        private float _salary;

        //prop
        public float Salary
        {
            get => _salary;
            set { if(value>=0) _salary = value; }
        }


        //methods
        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }
        public static bool operator <(Teacher t1, Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }

        public override string ShowInfo()
        {
            return $"ID: {Id} \nName: {Name} \nSurname: {Surname} \nAge: {Age} \nSalary: {Salary}";
        }

    }
}
