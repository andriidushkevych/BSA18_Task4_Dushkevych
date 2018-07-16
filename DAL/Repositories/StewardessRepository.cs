using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class StewardessRepository : Repository<Stewardess>
    {
        public StewardessRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
