using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileSearchAPIProject
{
    public class ProfileSummary
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string SearchQuery { get; set; }
        public string ProfilePhoto { get; set; }


    }
}
