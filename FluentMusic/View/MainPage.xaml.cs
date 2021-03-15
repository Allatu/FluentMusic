using System;
using Windows.UI.Xaml.Controls;
using FluentMusic.Classes;
using FluentMusic.Model;
using FluentMusic.View.Pages;
using FluentMusic.ViewModel;
using FluentMusic.ViewModel.Pages;
using NavigationView = Microsoft.UI.Xaml.Controls.NavigationView;
using NavigationViewSelectionChangedEventArgs = Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FluentMusic.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private SettingsViewModel _settingsViewModel;

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new MainViewModel();

            this._settingsViewModel = new SettingsViewModel();


            ThemeHelper.Initialize(); 

        }

        public MainViewModel ViewModel { get; set; }


        private void NavigationView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(SettingsPage), _settingsViewModel);
                return;
            }

            var selectedItem = (ViewModelBase)args.SelectedItem;
            
            if (selectedItem == null)
                return;

            ContentFrame.Navigate(selectedItem.PageType, selectedItem, args.RecommendedNavigationTransitionInfo);
        }
    }
}
