using MusicApp.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MusicApp.ViewModels
{
    public class TodayViewModel : BaseViewModel
    {
        public TodayViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoadQuickHelpMenu();
            LoadNewMusic();

            SelectedSongCommand = new DelegateCommand<Song>(OnSongSelected);
        }
        public Song SelectedSong
        {
            get
            {
                return _selectedSong;
            }
            set
            {
                _selectedSong = value;

                if (_selectedSong != null)
                {
                    SelectedSongCommand.Execute(_selectedSong);
                    SelectedSong = null;
                }
            }
        }

        private async void OnSongSelected(Song selectedSong)
        {
            NavigationParameters navigationParameters = new NavigationParameters
            {
                { "SongTitle", selectedSong.Title },
                { "SongImage", selectedSong.Image },
                { "SongSubtitle", selectedSong.Subtitle },
                { "SongDescription", selectedSong.Description },
            };

            await NavigationService.NavigateAsync(NavigationConstants.SongDetails, navigationParameters);
        }

        private void LoadQuickHelpMenu()
        {
            QuickHelpMenuList = new ObservableCollection<QuickHelpMenuOption>
            {
                new QuickHelpMenuOption("Breathe", "outline_air_black_48.png"),
                new QuickHelpMenuOption("Sleep", "sleeping_moon.png"),
                new QuickHelpMenuOption("Anxiety", "stressed_face.png"),
                new QuickHelpMenuOption("Stress", "neutral_face.png")
            };
        }

        private void LoadNewMusic()
        {
            NewMusicList = new ObservableCollection<Song>
            {
                new Song("Raining Sidewalk", "https://budsnblush.com/wp-content/uploads/2017/07/774db0706fde747de6a1e0965addc0d5_compress62.jpg", "5 mins", "Raining Sidewalk Article", "Raining ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Gravida quis blandit turpis cursus in hac. Lacus vestibulum sed arcu non odio euismod lacinia. Euismod in pellentesque massa placerat duis ultricies lacus. Nunc mi ipsum faucibus vitae aliquet nec. Feugiat pretium nibh ipsum consequat nisl vel pretium lectus."),
                new Song("Spring Morning", "https://www.poynter.org/wp-content/uploads/2019/07/shutterstock_264132746-1500x1017.jpg", "10 mins", "Spring Morning Article", "Spring ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Gravida quis blandit turpis cursus in hac. Lacus vestibulum sed arcu non odio euismod lacinia. Euismod in pellentesque massa placerat duis ultricies lacus. Nunc mi ipsum faucibus vitae aliquet nec. Feugiat pretium nibh ipsum consequat nisl vel pretium lectus."),
                new Song("First Smile", "https://juanbustos.com/wp-content/uploads/2020/01/jb-camgirl-1.jpg", "3 mins", "First Smile Inspiration", "First ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Gravida quis blandit turpis cursus in hac. Lacus vestibulum sed arcu non odio euismod lacinia. Euismod in pellentesque massa placerat duis ultricies lacus. Nunc mi ipsum faucibus vitae aliquet nec. Feugiat pretium nibh ipsum consequat nisl vel pretium lectus."),
                new Song("Amazing Grace", "https://www.incimages.com/uploaded_files/image/1920x1080/getty_74956750_9709709704500404_43668.jpg", "15 mins", "The great Grace of God", "Grace ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Gravida quis blandit turpis cursus in hac. Lacus vestibulum sed arcu non odio euismod lacinia. Euismod in pellentesque massa placerat duis ultricies lacus. Nunc mi ipsum faucibus vitae aliquet nec. Feugiat pretium nibh ipsum consequat nisl vel pretium lectus.")
            };
        }

        private Song _selectedSong;
        public override string Title => "Today";
        public ObservableCollection<QuickHelpMenuOption> QuickHelpMenuList { get; set; }
        public ObservableCollection<Song> NewMusicList { get; set; }
        public ICommand SelectedSongCommand { get; }
    }
}
