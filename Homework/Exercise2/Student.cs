using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exercise2
{
    internal class Student : Person
    {
        private float gpa;
        public float Gpa { get => gpa; set => gpa=value; }

        public Student()
        {
        }

        public Student(float gpa)
        {
            Gpa=gpa;
        }

        public Student(int age, int name, float gpa) : base(age, name)
        {
        }

        public void DisplayStudent()
        {

        }


    }
}
