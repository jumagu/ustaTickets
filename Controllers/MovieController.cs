using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ustaTickets.Data.Services;
using ustaTickets.Models;

namespace ustaTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(c => c.Cinema, d => d.Director);
            return View(data);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var data = await _service.GetAllAsync(c => c.Cinema, d => d.Director);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = data.Where(
                    n => n.Name.Contains(searchString) ||
                    n.Description.Contains(searchString)
                ).ToList();
                return View("Index", filteredResult);
            }

            return View("Index", data);
        }

        // Get: Movie/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetMovieByIdAsync(id);
            return View(data);
        }

        // Get: Movie/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(
                movieDropdownsData.Cinemas, "Id", "Name"
            );
            ViewBag.Directors = new SelectList(
                movieDropdownsData.Directors, "Id", "FullName"
            );
            ViewBag.Actors = new SelectList(
                movieDropdownsData.Actors, "Id", "FullName"
            );
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Directors = new SelectList(movieDropdownsData.Directors, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

                return View(movie);
            }
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        // Get: Movie/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("NotFound");

            var response = new NewMovieVM()
            {
                Id = movieDetails.Id,
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                ImageURL = movieDetails.ImageURL,
                MovieCategory = movieDetails.MovieCategory,
                CinemaId = movieDetails.CinemaId,
                DirectorId = movieDetails.DirectorId,
                ActorsIds = movieDetails.Actor_Movies.Select(a => a.ActorId).ToList(),
            };

            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Directors = new SelectList(movieDropdownsData.Directors, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if (id != movie.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Directors = new SelectList(movieDropdownsData.Directors, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

                return View(movie);
            }
            await _service.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
