using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_321_Week_2
{
    class SportsTeamInfo
    {
        public string coach, sportsTeam, location;

        public virtual string DisplaySport()
        {
            return "This is a virtual message from SportsTeamInfo Class";
        }
    }
}
