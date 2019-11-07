using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BusinessLogic.Interfaces;
using TMS.PresentationalModels;

namespace TMS.BusinessLogic
{
    public class TicketingManager : ITicketingManager
    {
        public TicketingManager()
        {

        }

        //Add a ticket
        public void AddTicket()
        {
            throw new NotImplementedException();
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
