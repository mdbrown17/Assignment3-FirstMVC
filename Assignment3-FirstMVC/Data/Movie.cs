namespace Assignment3_FirstMVC.Data
{
    public class Movie
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? ImdbHyperlink { get; set; }
        public string? Genre { get; set; }
        public int? RealeaseYear { get; set; }
        public string? Poster { get; set; }
    }
}
