/*
 * Andy Le
 * 000805099
 * Implementation of Song class
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{   
    /// <summary>
    /// Implementation of a class called Song which inherits from Media
    /// </summary>
    public class Song : Media
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        /// <summary>
        /// Constructor method for Song Class
        /// </summary>
        public Song(string album, string artist, string title, int year) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }

        /// <summary>
        /// Method for string output excluding summary
        /// </summary>
        public override string toString() => $"Song Title: {base.Title} ({base.Year})\nAlbum: {Album} Artist: {Artist}\n--------------------";

        /// <summary>
        /// Method for string output including summary
        /// </summary>
        public override string toString2() => $"Song Title: {base.Title} ({base.Year})\nAlbum: {Album} Artist: {Artist}\n--------------------";

    }
}
