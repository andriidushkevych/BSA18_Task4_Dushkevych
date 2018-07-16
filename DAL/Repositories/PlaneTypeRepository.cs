using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class PlaneTypeRepository : Repository<PlaneType>
    {
        public PlaneTypeRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
