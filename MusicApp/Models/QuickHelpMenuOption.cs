using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MusicApp.Models
{
    public class QuickHelpMenuOption : INotifyPropertyChanged
    {
        public QuickHelpMenuOption(string title, string icon)
        {
            Title = title;
            Icon = icon;
        }
        public string Icon { get; }
        public string Title { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
