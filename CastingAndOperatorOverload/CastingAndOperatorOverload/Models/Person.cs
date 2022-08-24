using System;
using System.Collections.Generic;
using System.Text;

namespace CastingAndOperatorOverload.Models
{
    abstract class Person
    {
        public Person()
        {
            _id++;
            Id = _id;
        }


        public int Id { get; }
        private static int _id;
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { if(value > 0) _age = value; }
        }

        virtual public string ShowInfo()
        {
            return $"ID: {_id} \nName: {Name} \nSurname: {Surname} \nAge: {Age}";
        }

    }
}
