using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ustaTickets.Data.Base;
using ustaTickets.Data.Enum;

namespace ustaTickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Cover")]
        public string ImageURL { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Data")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }
    }
}
