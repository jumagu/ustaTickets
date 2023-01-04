using Microsoft.EntityFrameworkCore;
using ustaTickets.Data.Base;
using ustaTickets.Data.ViewModels;
using ustaTickets.Models;

namespace ustaTickets.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly ApplicationDbContext _context;
        public MovieService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                DirectorId = data.DirectorId
            };
            await _context.Movie.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            // Add Movie Actors
            foreach (var actorId in data.ActorsIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await _context.Actor_Movie.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        public Task DeleteMovieAsync(NewMovieVM data)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movie
                .Include(c => c.Cinema)
                .Include(d => d.Director)
                .Include(am => am.Actor_Movies)
                .ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(m => m.Id == id);

            return movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Actors = await _context.Actor.OrderBy(a => a.FullName).ToListAsync(),
                Cinemas = await _context.Cinema.OrderBy(c => c.Name).ToListAsync(),
                Directors = await _context.Director.OrderBy(a => a.FullName).ToListAsync()
            };

            return response;
        }

        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            var dbMovie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == data.Id);
            if (dbMovie != null)
            {

                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description;
                dbMovie.Price = data.Price;
                dbMovie.ImageURL = data.ImageURL;
                dbMovie.CinemaId = data.CinemaId;
                dbMovie.StartDate = data.StartDate;
                dbMovie.EndDate = data.EndDate;
                dbMovie.MovieCategory = data.MovieCategory;
                dbMovie.DirectorId = data.DirectorId;

                await _context.SaveChangesAsync();
            }

            // Remove existing actors
            var existingActorsDb = await _context.Actor_Movie.Where(m => m.MovieId == data.Id).ToListAsync();
            _context.Actor_Movie.RemoveRange(existingActorsDb);
            await _context.SaveChangesAsync();

            // Add Movie Actors
            foreach (var actorId in data.ActorsIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = data.Id,
                    ActorId = actorId
                };
                await _context.Actor_Movie.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
    }
}
