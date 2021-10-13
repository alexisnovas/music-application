using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels
{
    public class YogaViewModel : BaseViewModel
    {
        public YogaViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public override string Title => "Yoga";
    }
}
