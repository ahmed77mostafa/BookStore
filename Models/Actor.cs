using System.ComponentModel.DataAnnotations;

namespace wTickets.Models
{
    public class Actor
    {
        [Key] public int actorId {  get; set; }
        [Required] public string actorName { get; set; }
        public string profilePicURL { get; set; }
        public string Bio { get; set; }
        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
