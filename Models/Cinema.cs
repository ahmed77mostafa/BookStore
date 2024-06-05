using System.ComponentModel.DataAnnotations;

namespace wTickets.Models
{
    public class Cinema
    {
        [Key] public int cinemaId { get; set; }
        [Required] public string cinemaName { get; set; }
        public string cinemaDescription { get; set; }
        public string logo { get; set; }
        public List<Movie> movies { get; set; }
    }
}
