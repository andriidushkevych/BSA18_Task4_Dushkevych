using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class PlaneRepository : Repository<Plane>
    {
        public PlaneRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
