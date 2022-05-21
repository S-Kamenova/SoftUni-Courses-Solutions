using System;
using System.Collections.Generic;
using System.Linq;

namespace L03.Songs
{
    class Song
    {
        public string Name { get; set; }
        public string TypeList { get; set; }
        public string Time { get; set; }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();


            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] token = Console.ReadLine()
                    .Split('_',
                    StringSplitOptions.RemoveEmptyEntries);
                string typeList = token[0];
                string name = token[1];
                string time = token[2];

                Song newSong = new Song()
                {
                    Name = name,
                    TypeList = typeList,
                    Time = time
                };
                songs.Add(newSong);
            }
            string comand = Console.ReadLine();
            if (comand=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                var filterSongs = songs
                    .FindAll(song => song.TypeList == comand);

                foreach (var song in filterSongs)
                {
                    Console.WriteLine(song.Name);
                }

               // Console.WriteLine(string.Join(Environment.NewLine,filterSongs.Select(song=>song.Name)));
            }
        }
    }
}
