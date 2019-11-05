using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.PocoData
{
    public class Role
    {
        public int RoleId { get; set; }

        public string RoleCode { get; set; }

        public string Description { get; set; }

        public bool IsClient { get; set; }

        public bool IsManagement { get; set; }
    }
}
