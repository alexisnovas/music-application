using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public override string Title => "Profile";
    }
}
