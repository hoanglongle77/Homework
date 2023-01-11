
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exercise1
{
    internal class Dice
    {
        private int sides;
        public int Sides { get { return sides; } set { sides = value; } }

        public Dice(int sides)
        {
            Sides=sides;
        }

        public Dice() { }

        public int Roll()
        {
            return sides;
        }
    }
}
