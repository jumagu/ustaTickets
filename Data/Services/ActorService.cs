using Microsoft.EntityFrameworkCore;
using ustaTickets.Data.Base;
using ustaTickets.Models;

namespace ustaTickets.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(ApplicationDbContext context) : base(context) { }
    }
}
