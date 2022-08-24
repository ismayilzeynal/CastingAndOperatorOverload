using System;
using System.Collections.Generic;
using System.Text;

namespace CastingAndOperatorOverload.Models
{
    class Student:Person
    {
        //ctor
        public Student(string name,string surname, int point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }
        public Student(string name, string surname, int point, int age):this(name, surname, point)
        {
            Age = age;
        }


        //field
        private int _point;


        //prop
        public int Point
        {
            get => _point;
            set { if(value>=0) _point = value; }
        }


        //methods
        public static bool operator >(Student st1, Student st2)
        {
            return st1.Point > st2.Point;
        }
        public static bool operator <(Student st1, Student st2)
        {
            return st1.Point < st2.Point;
        }

        public override string ShowInfo()
        {
            return $"ID: {Id} \nName: {Name} \nSurname: {Surname} \nAge: {Age} \nPoint: {Point}";
        }
    }
}
