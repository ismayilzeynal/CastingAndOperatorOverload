using System;
using System.Collections.Generic;
using System.Text;

namespace CastingAndOperatorOverload.Models
{
    class GroupMate
    {
        // field and prop
        private Student[] _students;
        
        // ctor's
        public GroupMate()
        {
            _students = new Student[0];
        }
        public GroupMate(int length)
        {
            _students = new Student[length];
        }


        //indexer
        public Student this[int index]
        {
            get
            {
                if (index < _students.Length)
                {
                    return _students[index];
                }
                else
                    throw new ArgumentOutOfRangeException("Parameter index is out of range.");
            }
            set
            {
                if (index < _students.Length)
                {
                    _students[index] = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Parameter index is out of range.");
            }
        }

        public void AddStudent(params Student[] students)
        {
            int OldLength = _students.Length;

            Array.Resize(ref _students, OldLength + students.Length);
            for (int i = OldLength; i < _students.Length; i++)
            {
                _students[i] = students[i - OldLength];
            }
        }



        // Sort() with operator overloading
        public void Sort()
        {
            for (int i = 0; i < _students.Length; i++)
            {
                for (int j = i + 1; j < _students.Length; j++) 
                {
                    if (_students[i] < _students[j])        // we use operator overlading
                    {
                        Student temp = _students[i];
                        _students[i] = _students[j];
                        _students[j] = temp;
                    }
                }
            }
        }





    }
}
