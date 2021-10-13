using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Models
{
    public class Song
    {
        public Song(string title, string image, string duration, string subtitle, string description)
        {
            Title = title;
            Image = image;
            Duration = duration;
            Subtitle = subtitle;
            Description = description;
        }
        public string Title { get; }
        public string Image { get; }
        public string Duration { get; }
        public string Subtitle { get; }
        public string Description { get; }
    }
}
