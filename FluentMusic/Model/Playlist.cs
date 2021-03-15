using System.Collections.ObjectModel;

namespace FluentMusic.Model
{
    public class Playlist
    {
        public string Name { get; set; }

        public ObservableCollection<Song> Songs { get; set; }

        public bool Favorite { get; set; }
    }
}
