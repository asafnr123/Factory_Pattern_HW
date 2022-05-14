using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class VegDietFactory : RightDietFactory
    {
        public override bool CheckRightDiet(Athlete athlete)
        {
            if (athlete.age >= 15 && (athlete.height >= 140 && athlete.height <= 150 && (athlete.weight >= 55 && athlete.weight <= 65)))
                return true;
            if (athlete.age >= 15 && (athlete.height >= 150 && athlete.height <= 160 && (athlete.weight >= 65 && athlete.weight <= 75)))
                return true;   
            if (athlete.age >= 15 && (athlete.height >= 160 && athlete.height <= 170 && (athlete.weight >= 75 && athlete.weight <= 85)))
                return true;   
            if (athlete.age >= 15 && (athlete.height >= 170 && athlete.height <= 180 && (athlete.weight >= 85 && athlete.weight <= 95)))
                return true;   
            if (athlete.age >= 15 && (athlete.height >= 180 && athlete.height <= 190 && (athlete.weight >= 95 && athlete.weight <= 110)))
                return true;   
            if (athlete.age >= 15 && (athlete.height >= 190 && athlete.height <= 200 && (athlete.weight >= 110 && athlete.weight <= 125)))
                return true;
            else
                return false;
        }

        public override DietBase GetDiet()
        {
            return new VegDiet();
        }
    }
}
