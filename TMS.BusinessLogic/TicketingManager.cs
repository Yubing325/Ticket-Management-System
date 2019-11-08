using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BusinessLogic.Interfaces;
using TMS.PocoData;
using TMS.PresentationalModels;

namespace TMS.BusinessLogic
{
    public class TicketingManager : ITicketingManager
    {
        private readonly TmsContext context;

        public TicketingManager(TmsContext context)
        {
            this.context = context;
        }

        //Add a ticket
        public void AddTicket(TicketModel model)
        {
            var ticket = new Ticket
            {
                Title = model.TicketTitle,
                Description = model.TicketDescription,
                CreatedTime = DateTime.Now
            };

            context.Add<Ticket>(ticket);
            context.SaveChanges();

        }
        //Soft delete a ticket
        public void DeleteTicket(int ticketId)
        {
            throw new NotImplementedException();
        }
        //Update a specific ticket
        public void EditTicket(int ticketId)
        {
            throw new NotImplementedException();
        }
        //Retrieve All Tickets
        public ICollection<TicketModel> GetAllTickets()
        {
            throw new NotImplementedException();
        }
        //Retrieve a specific ticket by ticketId
        public TicketModel GetTicketById(int ticketId)
        {
            throw new NotImplementedException();
        }

    }
}
