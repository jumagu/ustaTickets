using Microsoft.AspNetCore.Mvc;
using ustaTickets.Data.Services;
using ustaTickets.Models;

namespace ustaTickets.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IDirectorService _service;

        public DirectorController(IDirectorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get: Directors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Director director)
        {
            if (!ModelState.IsValid)
            {
                return View(director);
            }
            await _service.AddAsync(director);
            return RedirectToAction(nameof(Index));
        }
        //Get: Directors/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var directorDetails = await _service.GetByIdAsync(id);
            if (directorDetails == null) return View("NotFound");
            return View(directorDetails);
        }

        //Get: Director/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var directorDetails = await _service.GetByIdAsync(id);
            if (directorDetails == null) return View("NotFound");
            return View(directorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, ProfilePictureURL, FullName, Bio")] Director director)
        {
            if (!ModelState.IsValid)
            {
                return View(director);
            }
            await _service.UpdateAsync(id, director);
            return RedirectToAction(nameof(Index));
        }
        //Get: Director/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var directorDetails = await _service.GetByIdAsync(id);
            if (directorDetails == null) return View("NotFound");
            return View(directorDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var directorDetails = await _service.GetByIdAsync(id);
            if (directorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
