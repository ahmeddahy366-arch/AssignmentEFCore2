using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFCore2.model
{
    internal class Badge
    {

        public int Id { get; set; }

        public string BadgeNumber { get; set; }

        public DateTime IssueDate { get; set; }
        public int attendeeid { get; set; }
        public Attendee attendee { get; set; }

    }
}
