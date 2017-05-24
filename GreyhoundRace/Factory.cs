using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyhoundRace
{
    public class Factory
    {
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Joe();
                case 1: return new McGee();
                case 2: return new George();
                default: return null;
            }
        }

    }
}
