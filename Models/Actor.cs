using System.ComponentModel.DataAnnotations;
using ustaTickets.Data.Base;

namespace ustaTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Fullname")]
        [Required(ErrorMessage = "Fullname is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Fullname must be between 3 and 50")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; } 
    }
}
