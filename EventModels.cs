using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }
    }
}
