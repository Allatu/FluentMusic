using System;
using Windows.UI.Xaml.Controls;

namespace FluentMusic.Model
{
    public class PageItem
    {
        public string Header { get; set; }

        public string Tooltip { get; set; }

        public Symbol Symbol { get; set; }

        public Type PageType { get; set; }
    }
}
