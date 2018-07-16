using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class PilotRepository : Repository<Pilot>
    {
        public PilotRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
