namespace AllMoviesAPI.DTOs
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Synopsis { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public int Runtime { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime RelaseDate { get; set; } = DateTime.Today;
        public int GenreId { get; set; }
        public int AudienceRatingId { get; set; }

    }
}
