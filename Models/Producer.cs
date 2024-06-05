using System.ComponentModel.DataAnnotations;

namespace wTickets.Models
{
    public class Producer
    {
        [Key] public int producerId { get; set; }
        [Required] public string producerName { get; set; }
        public string Bio { get; set; }
        public string profilePicURL { get; set; }
        public List<Movie> movies { get; set; }
    }
}
