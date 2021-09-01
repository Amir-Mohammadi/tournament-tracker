using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTracker
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeanNames { get; set; }
    }
}
