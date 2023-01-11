using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exercise3
{
    internal class Song
    {
        private string typeList;
        private string name;
        private string time;

        public string TypeList { get => typeList; set => typeList=value; }
        public string Name { get => name; set => name=value; }
        public string Time { get => time; set => time=value; }

        public Song(string typeList, string name, string time)
        {
            TypeList=typeList;
            Name=name;
            Time=time;
        }

        public Song()
        {
        }
    }
}
