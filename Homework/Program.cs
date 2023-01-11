using Homework.Exercise1;
using Homework.Exercise3;

using System;
using System.Collections.Generic;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestExercise3();
        }

      

        public static void TestExercise1()
        {

        }
        public static void TestExercise2()
        {

        }

        public static void TestExercise3()
        {
            Console.Write("Enter numbers of song: ");
            int numSongs = int.Parse(Console.ReadLine());

            List<Song> mySongList = new List<Song>();
            for(int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1]; 
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                mySongList.Add(song);
            }

            Console.Write("Enter type list of song: ");
            string typeList = Console.ReadLine();

            if(typeList == "all")
            {
                foreach(Song song in mySongList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song in mySongList)
                {
                    if(song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

    }
}
