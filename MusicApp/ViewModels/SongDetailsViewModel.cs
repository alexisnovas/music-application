using MusicApp.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels
{
    public class SongDetailsViewModel : BaseViewModel, INavigationAware
    {
        public SongDetailsViewModel(INavigationService navigationService) : base(navigationService) 
        {

        }
        public string SongTitle { get; set; }
        public string SongImage { get; set; }
        public string SongSubtitle { get; set; }
        public string SongDescription { get; set; }

        public override string Title => throw new NotImplementedException();

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            SongTitle = parameters.GetValue<string>(nameof(SongTitle));
            SongImage = parameters.GetValue<string>(nameof(SongImage));
            SongSubtitle = parameters.GetValue<string>(nameof(SongSubtitle));
            SongDescription = parameters.GetValue<string>(nameof(SongDescription));
        }
    }
    
}
