using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class Nutritionist
    {
        public string nutritionistName;


        public Nutritionist(string name)
        {
            nutritionistName = name;
            
        }


        public void ChooseRightDiet(RightDietFactory[] diets, Athlete athlete)
        {
            foreach (var obj in diets)
            {
                if(obj.CheckRightDiet(athlete))
                {
                    DietBase diet = obj.GetDiet();
                    athlete.menu = diet.GetMenu();
                    Console.WriteLine("Enjoy you'r diet and dont forget to drink a lot of water");
                    athlete.ThankDoctor($"Thanks Doctor {nutritionistName}");
                    
                }
            }
            if (athlete.menu == null)
                Console.WriteLine("Sorry we didn't find a diet right for you");
        }
    }
}
