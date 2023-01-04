using ustaTickets.Data.Base;
using ustaTickets.Models;

namespace ustaTickets.Data.Services
{
    public class DirectorService : EntityBaseRepository<Director>, IDirectorService
    {
        public DirectorService(ApplicationDbContext context) : base(context) { }
    }
}
