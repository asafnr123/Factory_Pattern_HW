using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class PaleolithicDiet : DietBase
    {
        public PaleolithicDiet()
        {
            menu = "9:00: Water + Fruit \n" +
                "14:00: Rice + Beef \n" +
                "18:00: Chicken breast + Salad \n" +
                "21:00: Beef";
        }
    }
}
