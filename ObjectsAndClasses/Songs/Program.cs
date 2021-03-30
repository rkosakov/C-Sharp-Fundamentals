using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                string[] elements = Console.ReadLine().Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

                string type = elements[0];
                string name = elements[1];
                string time = elements[2];

                Song song = new Song()
                {
                    Type = type,
                    Name = name,
                    Time = time
                };

                songs.Add(song);
            }

            string typeSongs = Console.ReadLine();

            List<Song> filteredSongs = songs.Where(s => s.Type == typeSongs).ToList();

            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(String.Join(Environment.NewLine, song.Name));
            }

            if (typeSongs == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(String.Join(Environment.NewLine, song.Name));
                }
            }


        }
    }

    class Song
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    
}
