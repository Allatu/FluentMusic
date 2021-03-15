using Windows.UI.Xaml.Navigation;
using FluentMusic.ViewModel.Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FluentMusic.View.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        public new HomeViewModel ViewModel => (HomeViewModel) base.ViewModel;


    }
    


}
