using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class DepartureRepository : Repository<Departure>
    {
        public DepartureRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
