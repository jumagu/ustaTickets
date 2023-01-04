using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using ustaTickets.Data.Base;

namespace ustaTickets.Models
{
    public class Director : IEntityBase
    {
        [Key] 
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Fullname")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
