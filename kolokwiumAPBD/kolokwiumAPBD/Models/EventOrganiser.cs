using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwiumAPBD.Models
{
    public class EventOrganiser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrganiserEvent { get; set; }

        [Required]
        [ForeignKey("IdOrganiser")]
        public int IdOrganiser { get; set; }

        public Organiser Organiser { get; set; }

        [Required]
        [ForeignKey("IdEvent")]
        public int IdEvent { get; set; }

        public Event Event { get; set; }
        
        public DateTime PerformanceDate { get; set; }
    }
}