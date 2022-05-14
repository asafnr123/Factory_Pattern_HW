using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class AtkinsDiet : DietBase
    {
        public AtkinsDiet()
        {
            menu = "9:00: Water + Fruit \n" +
                "14:00: Salad + Chicken breast \n" +
                "18:00: Fruit + crackers with white cheese \n" +
                "21:00: Fruit Salad + Greek yogurt & Oats";
        }
    }
}
