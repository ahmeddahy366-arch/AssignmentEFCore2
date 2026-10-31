using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFCore2.model
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string Biography { get; set; }

        public string? Website { get; set; }

        public string? Logo { get; set; }
        public int Organizerid { get; set; }
        public Organizer Organizer { get; set; }
    }
}
