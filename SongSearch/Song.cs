using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSearch
{
    public class Song
    {
        // Instance Variables
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public string SongGenre { get; set; }

        public override string ToString()
        {
            return "Song Title: " + SongTitle + "\n" +
                   "Song Aroid: " + SongArtist + "\n" +
                   "Song Genre: " + SongGenre + "\n";
        }
    }
}