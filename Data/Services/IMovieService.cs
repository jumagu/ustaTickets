using ustaTickets.Data.Base;
using ustaTickets.Data.ViewModels;
using ustaTickets.Models;

namespace ustaTickets.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
        Task DeleteMovieAsync(NewMovieVM data);
    }
}
