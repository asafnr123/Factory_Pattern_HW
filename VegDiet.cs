using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class VegDiet : DietBase
    {
        public VegDiet()
        {
            menu = "9:00: Tea + Any Fruit \n" +
                "14:00: Rice + Salad \n" +
                "18:00: Any Fruit \n" +
                "21:00: Salad + Omlete + crackers with white cheese";
        }        
    }
}
