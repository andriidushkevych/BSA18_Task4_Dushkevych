using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class FlightRepository : Repository<Flight>
    {
        public FlightRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
