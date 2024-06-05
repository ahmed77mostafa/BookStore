namespace wTickets.Models
{
    public class Actor_Movie
    {
        public int actorId { get; set; }
        public Actor Actor { get; set; }
        public int movieId { get; set; }
        public Movie Movie { get; set; }
    }
}