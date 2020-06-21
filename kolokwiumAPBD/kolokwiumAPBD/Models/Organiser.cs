using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwiumAPBD.Models
{
    public class Organiser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrganiser { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

      
    }
}