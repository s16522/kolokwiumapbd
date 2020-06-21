using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwiumAPBD.Models
{
    public class ArtistEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArtistEvent { get; set; }

        [Required]
        [ForeignKey("IdArtist")]
        public int IdArtist { get; set; }

        public Artist Artist { get; set; }

        [Required]
        [ForeignKey("IdEvent")]
        public int IdEvent { get; set; }

        public Event Event { get; set; }
        
        public DateTime PerformanceDate { get; set; }
    }
}