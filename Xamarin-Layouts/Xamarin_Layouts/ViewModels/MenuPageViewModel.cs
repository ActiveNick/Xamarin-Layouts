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
        public ICommand GoSettingsCommand { get; set; }

        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoLoginCommand = new Command(GoLogin);
            GoButtonGridCommand = new Command(GoButtonGrid);
            GoGridLayoutCommand = new Command(GoGridLayout);
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

        void GoSettings(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new Settings());
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
    }
}

