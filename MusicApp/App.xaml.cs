using MusicApp.ViewModels;
using MusicApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{NavigationConstants.Nav}/{NavigationConstants.Main}?{KnownNavigationParameters.SelectedTab}={NavigationConstants.Today}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.Nav);
            containerRegistry.RegisterForNavigation<MainTabbedPage, MainViewModel>(NavigationConstants.Main);
            containerRegistry.RegisterForNavigation<SongDetailsPage, SongDetailsViewModel>(NavigationConstants.SongDetails);
            containerRegistry.RegisterForNavigation<TodayPage, TodayViewModel>(NavigationConstants.Today);
            containerRegistry.RegisterForNavigation<YogaPage, YogaViewModel>(NavigationConstants.Yoga);
            containerRegistry.RegisterForNavigation<MeditationPage, MeditationViewModel>(NavigationConstants.Meditation);
            containerRegistry.RegisterForNavigation<MealPage, MealViewModel>(NavigationConstants.Meal);
            containerRegistry.RegisterForNavigation<ProfilePage, ProfileViewModel>(NavigationConstants.Profile);

        }
    }
}
