using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using FluentMusic.Classes;
using FluentMusic.Model;
using FluentMusic.View.Pages;
using FluentMusic.ViewModel.Pages;

namespace FluentMusic.ViewModel
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            Pages = new ObservableCollection<ViewModelBase>
            {
                new HomeViewModel()
            };


        }

        public ObservableCollection<ViewModelBase> Pages
        {
            get => _pages;
            set
            {
                if (Equals(value, _pages)) return;
                _pages = value;
                OnPropertyChanged(nameof(Pages));
            }
        }

        private ObservableCollection<ViewModelBase> _pages;
    }
}
