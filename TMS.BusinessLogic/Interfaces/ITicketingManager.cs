using System;
using System.Collections.Generic;
using System.Text;
using TMS.PresentationalModels;

namespace TMS.BusinessLogic.Interfaces
{
    public interface ITicketingManager
    {
        //Add a ticket
        void AddTicket();

        //Retrieve All Tickets
        ICollection<TicketModel> GetAllTickets();

        //Retrieve a specific ticket by ticketId
        TicketModel GetTicketById(int ticketId);
        //Update a specific ticket
        void EditTicket(int ticketId);

        //Soft delete a ticket
        void DeleteTicket(int ticketId);
    }
}
