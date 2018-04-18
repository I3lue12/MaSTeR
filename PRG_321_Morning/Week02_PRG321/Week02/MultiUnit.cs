using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class MultiUnit : Housing, Interface1
    {
        public override int NumberUnits()
        {
            return 20;
        }
    }
}
