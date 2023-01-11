using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exercise2
{
    internal class Person
    {
        private int age;
        private int name;


        public int Age { get => age; set => age=value; }
        public int Name { get => name; set => name=value; }
        public Person()
        {
        }

        public Person(int age, int name)
        {
            Age=age;
            Name=name;
        }

        public void DisplayPerson()
        {

        }

        public void Input()
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
