using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_HW
{
    internal class Athlete
    {
        public int age;
        public int height;
        public int weight;
        public string menu;

        public Athlete(int age, int height, int weight)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public void ThankDoctor(string text)
        {
            Console.WriteLine(text);
        }
    }
}
