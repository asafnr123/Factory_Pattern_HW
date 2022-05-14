using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal abstract class RightDietFactory
    {
        public abstract bool CheckRightDiet(Athlete athlete);
        public abstract DietBase GetDiet();
    }
}
