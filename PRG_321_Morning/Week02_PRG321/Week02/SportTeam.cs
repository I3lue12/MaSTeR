using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class SportTeam
    {
        private int m_address;
        private Coach m_coach;
        
        public Coach Coach
        {
            get
            {
                return m_coach;
            }
            set
            {
                m_coach = value;
            }

        }
        public virtual string DisplaySportsLocation(string location)
        {
            string city = "City: ";
            return city;
        }
        public virtual string DisplaySportsTeam()
        {
            string sportName = "SportName";
            return sportName;
        }
        
    }
    

}