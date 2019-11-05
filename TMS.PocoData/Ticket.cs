using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.PocoData
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDeleted { get; set; }

    }
}
