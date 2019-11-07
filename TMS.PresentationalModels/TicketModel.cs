using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.PresentationalModels
{
    public class TicketModel
    {
        public int TicketId { get; set; }

        public string TicketDescription { get; set; }

        public string TicketTitle { get; set; }

        public DateTime CreatedTime { get; set; }


    }
}
