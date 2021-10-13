using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels
{
    public class MeditationViewModel : BaseViewModel
    {
        public MeditationViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public override string Title => "Meditation";
    }
}
