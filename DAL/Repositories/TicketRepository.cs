using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;

namespace DAL.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        DataSource ds;
        public TicketRepository(DataSource ds)
        {
            this.ds = ds;
        }

        public List<Ticket> FetchAll()
        {
            return ds.GetTickets();
        }

        public void Add(Ticket entity)
        {

        }

        public void Update(Ticket entity)
        {

        }

        public void Delete(Ticket entity)
        {
        }

        public void Save()
        {
        }
    }
}
