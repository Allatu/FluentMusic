using System;
using Windows.UI.Xaml.Controls;

namespace FluentMusic.Classes
{
    public class ViewModelBase : BindableBase
    {
        public Symbol Symbol { get; set; }
        
        public string Header { get; set; }

        public string Tooltip { get; set; }

        public Type PageType { get; protected set; }
    }

    public class ViewModelBase<TPageType> : ViewModelBase
    {
        protected ViewModelBase()
        {
            PageType = typeof(TPageType);
        }
    }
}
