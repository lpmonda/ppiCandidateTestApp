using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ppiCandidateTestApp.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Firstname { get; set; }

        //public DateOnly ReleaseDate { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Lastname { get; set; }
                       
        
        public string? Phone { get; set; }

        [Required]        
        [Column(TypeName = "decimal(5, 0)")]
        public int zipcode { get; set; }

        [Required]        
        public string? email { get; set; }

        
    }
}
