using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class TicketRepository : Repository<Ticket>
    {
        public TicketRepository(AirportContext ctx): base(ctx)
        {

        }
    }
}
