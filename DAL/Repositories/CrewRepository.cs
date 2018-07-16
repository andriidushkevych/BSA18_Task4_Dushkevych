using DAL.Model;
using DAL.DB;

namespace DAL.Repositories
{
    public class CrewRepository : Repository<Crew>
    {
        public CrewRepository(AirportContext ctx) : base(ctx)
        {

        }
    }
}
