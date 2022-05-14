using System;

namespace Factory_Pattern_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete1 = new Athlete(14, 163, 60);
            Athlete athlete2 = new Athlete(18, 175, 60);
            Athlete athlete3 = new Athlete(16, 180, 95);
            Athlete athlete4 = new Athlete(20, 170, 50);
            Athlete athlete5 = new Athlete(20, 185, 90);


            RightDietFactory vegDiet = new VegDietFactory();
            RightDietFactory paleoDiet = new PaleolithicDietFactory();
            RightDietFactory atkinsDiet = new AtkinsDietFactory();

            RightDietFactory[] arr = new RightDietFactory[] { vegDiet, paleoDiet, atkinsDiet };

            Nutritionist nutritionist = new Nutritionist("Mark");
            nutritionist.ChooseRightDiet(arr, athlete1);
            nutritionist.ChooseRightDiet(arr, athlete2);
            nutritionist.ChooseRightDiet(arr, athlete3);
            nutritionist.ChooseRightDiet(arr, athlete4);
            nutritionist.ChooseRightDiet(arr, athlete5);


        }
    }
}
