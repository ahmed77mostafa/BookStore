using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wTickets.Data.@enum;

namespace wTickets.Models
{
    public class Movie
    {
        [Key] public int movieId { get; set; }
        [Required] public string movieName { get; set; } = string.Empty;
        public double price { get; set; }
        public string description { get; set; }
        public string ImageURL { get; set; }
        public DateTime movieStartDate { get; set; }
        public DateTime movieEndDate { get; set; }
        public movieCategory category { get; set; }
        public List<Actor_Movie> Actor_Movie { get; set; }
        
        // Cinema
        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")]
        public Cinema cinema { get; set; }

        // Producer
        public int producerId { get; set; }
        [ForeignKey("producerId")]
        public Producer producer { get; set; }
    }
}
