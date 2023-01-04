using System.ComponentModel.DataAnnotations;
using ustaTickets.Data.Enum;

namespace ustaTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Cover")]
        [Required(ErrorMessage = "Movie cover is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Data")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorsIds { get; set; }

        [Display(Name = "Select Cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Movie Director")]
        [Required(ErrorMessage = "Movie director is required")]
        public int DirectorId { get; set; }
    }
}
