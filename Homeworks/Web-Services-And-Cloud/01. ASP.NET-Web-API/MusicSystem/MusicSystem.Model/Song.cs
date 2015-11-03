namespace MusicSystem.Model
{
    public class Song
    {
        public Song()
        {
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }

        public int? ArtistId { get; set; }

        public virtual Album Artist { get; set; }
    }
}
