using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class PaleolithicDietFactory : RightDietFactory
    {
        public override bool CheckRightDiet(Athlete athlete)
        {
            if (athlete.age >= 16 && (athlete.height >= 140 && athlete.height <= 150 && (athlete.weight >= 30 && athlete.weight <= 40)))
                return true;
            if (athlete.age >= 16 && (athlete.height >= 150 && athlete.height <= 160 && (athlete.weight >= 40 && athlete.weight <= 50)))
                return true;
            if (athlete.age >= 16 && (athlete.height >= 160 && athlete.height <= 170 && (athlete.weight >= 50 && athlete.weight <= 60)))
                return true;
            if (athlete.age >= 16 && (athlete.height >= 170 && athlete.height <= 180 && (athlete.weight >= 60 && athlete.weight <= 70)))
                return true;
            if (athlete.age >= 16 && (athlete.height >= 180 && athlete.height <= 190 && (athlete.weight >= 70 && athlete.weight <= 80)))
                return true;
            if (athlete.age >= 16 && (athlete.height >= 190 && athlete.height <= 200 && (athlete.weight >= 80 && athlete.weight <= 90)))
                return true;
            else
                return false;
        }

        public override DietBase GetDiet()
        {
            return new PaleolithicDiet();
        }
    }
}
