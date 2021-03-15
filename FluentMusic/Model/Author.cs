using System.Collections.ObjectModel;

namespace FluentMusic.Model
{
    public class Author
    {
        public string Name { get; set; }

        public ObservableCollection<Album> Albums { get; set; }

    }
}
