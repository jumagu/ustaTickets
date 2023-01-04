using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using ustaTickets.Data.Base;

namespace ustaTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 40 characters.")]
        public string Name { get; set; }
        
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
