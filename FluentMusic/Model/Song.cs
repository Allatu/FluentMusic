using System.Linq;

namespace FluentMusic.Model
{
    public class Song
    {
        public string Name { get; set; }

        public Author Author  { get; set; }

        public Author[] FeaturedAuthors { get; set; }

        public override string ToString()
        {
            return BuildTitle();
        }

        private string BuildTitle()
        {
            if (Author == null)
                return Name;


            var authorName = Author.Name;

            if (FeaturedAuthors == null || !FeaturedAuthors.Any()) 
                return $"{Name} - {authorName}";

            var authorNames = string.Join(", ", FeaturedAuthors.ToList());

            return $"{Name} - {authorName}, {authorNames}";
        }
    }
}
