using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels
{
    public class MealViewModel : BaseViewModel
    {
        public MealViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public override string Title => "Meal";
    }
}
