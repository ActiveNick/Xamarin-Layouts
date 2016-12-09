using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Layouts
{
    public class MenuPageViewModel
    {

        public ICommand GoHomeCommand { get; set; }
        public ICommand GoGridLayoutCommand { get; set; }
        public ICommand GoSettingsCommand { get; set; }

        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoGridLayoutCommand = new Command(GoGridLayout);
            GoSettingsCommand = new Command(GoSettings);
        }

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoSettings(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new Settings());
            App.MenuIsPresented = false;
        }

        void GoGridLayout(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new GridLayoutXaml());
            App.MenuIsPresented = false;
        }
    }
}

