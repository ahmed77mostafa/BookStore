using System.ComponentModel.DataAnnotations;
using wTickets.Data.@enum;

namespace wTickets.Models
{
    public class Movie
    {
        [Key] public int movieId { get; set; }
        [Required] public string movieName { get; set; } = string.Empty;
        public int price { get; set; }
        public string description { get; set; }
        public DateTime movieStartDate { get; set; } = DateTime.Now;
        public DateTime movieEndDate { get; set; } = DateTime.MinValue;
        public movieCategory category { get; set; }
        public Producer producer { get; set; }
        public Cinema cinema { get; set; }
        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
