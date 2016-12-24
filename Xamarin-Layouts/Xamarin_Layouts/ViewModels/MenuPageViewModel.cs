using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Layouts
{
    public class MenuPageViewModel
    {

        public ICommand GoHomeCommand { get; set; }
        public ICommand GoLoginCommand { get; set; }
        public ICommand GoButtonGridCommand { get; set; }
        public ICommand GoGridLayoutCommand { get; set; }
        public ICommand GoSurveyLayoutCommand { get; set; }
        public ICommand GoUserProfileCommand { get; set;  }
        public ICommand GoSettingsCommand { get; set; }

        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoLoginCommand = new Command(GoLogin);
            GoButtonGridCommand = new Command(GoButtonGrid);
            GoGridLayoutCommand = new Command(GoGridLayout);
            GoSurveyLayoutCommand = new Command(GoSurveyLayout);
            GoUserProfileCommand = new Command(GoUserProfile);
            GoSettingsCommand = new Command(GoSettings);
        }

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoLogin(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new LoginPage());
            App.MenuIsPresented = false;
        }

        
        void GoButtonGrid(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new ButtonGridPage());
            App.MenuIsPresented = false;
        }

        void GoGridLayout(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new GridLayoutPage());
            App.MenuIsPresented = false;
        }

        void GoSurveyLayout(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new SurveyPage());
            App.MenuIsPresented = false;
        }

        void GoUserProfile(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new UserProfilePage());
            App.MenuIsPresented = false;
        }

        void GoSettings(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new Settings());
            App.MenuIsPresented = false;
        }
    }
}

