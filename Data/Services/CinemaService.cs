using ustaTickets.Data.Base;
using ustaTickets.Models;

namespace ustaTickets.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(ApplicationDbContext context) : base(context) { }
    }
}
