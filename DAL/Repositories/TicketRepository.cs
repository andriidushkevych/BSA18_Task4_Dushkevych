using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;

namespace DAL.Repositories
{
    public class TicketRepository : Repository<Ticket>
    {
        public override void Update(Guid id, Ticket entity)
        {
            Ticket ticketToUpdate = data.Where(t => t.Id.Equals(id)).First();
            ticketToUpdate.FlightNumber = entity.FlightNumber;
            ticketToUpdate.Price = entity.Price;
        }
    }
}
