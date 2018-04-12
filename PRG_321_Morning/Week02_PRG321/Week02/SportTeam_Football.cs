using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class SportTeam_Football : SportTeam
    {
        public override String DisplaySportsTeam()
        {
            string sportName = "Football";
            return sportName;

        }
        public override string DisplaySportsLocation(string footballLocation)
        {
            string location = footballLocation;
            return location;
        }
    }
}