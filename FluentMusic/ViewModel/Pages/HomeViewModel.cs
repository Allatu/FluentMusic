using Windows.UI.Xaml.Controls;
using FluentMusic.Classes;
using FluentMusic.View.Pages;

namespace FluentMusic.ViewModel.Pages
{
    public class HomeViewModel : ViewModelBase<HomePage>
    {
        public HomeViewModel()
        {
            Header = "Home";
            Symbol = Symbol.Home;
            Tooltip = "Homepage";
            
        }
    }
}
