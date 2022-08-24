using CastingAndOperatorOverload.Models;
using System;

namespace CastingAndOperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ismayil = new Student("Ismayil", "Zeynalov", 100, 20);
            Person Ulvi = new Teacher("Ulvi", "Abdullazada", 5000, 22);
            Person Huseyn = new Student("Huseyn", "Aliyev", 70,17);
            Person Kamran = new Student("Kamran", "Huseynov", 88, 24);
            GroupMate P326 = new GroupMate();



            Person[] Persons = { Ismayil, Ulvi, Huseyn, Kamran };
            foreach (Person item in Persons)
            {
                if (item is Student)
                {
                    Student std= (Student)item;
                    P326.AddStudent(std);
                }
            }

            


        }
    }
}
