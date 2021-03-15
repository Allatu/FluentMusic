using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FluentMusic.Classes
{
    public abstract class PageBase : Page
    {
        protected object ViewModel { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel = e.Parameter;
            base.OnNavigatedTo(e);
        }
    }
}
