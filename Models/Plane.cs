using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Plane
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Type { get; set; }

    }
}
