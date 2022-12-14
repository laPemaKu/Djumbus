using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djumbus
{
    internal class Program
    {
        class FoodType 
        {
            static int counter=0;
            private string name;
            private int protein;
            private int carbs;
            private int fat;

            public FoodType()
            {

            }
            public FoodType(string name, int protein, int carbs, int fat)
            {
                this.name = name;
                this.protein = protein;
                this.carbs = carbs;
                this.fat = fat;
                counter++;

            }

            public string Name { get => name; set => name = value; }
            public int Protein { get => protein; set => protein = value; }
            public int Carbs { get => carbs; set => carbs = value; }
            public int Fat { get => fat; set => fat = value; }

            override public string ToString()
            {
                return this.name + ": p - " + this.protein + "%, c - " + this.carbs + "%, f - " + this.fat + "%";
            }

            static int getNumberOfCreatedInstances()
            {
                return counter;
            }

        }
        class Food
        {
            int weight;
            FoodType type;

            public Food(int weight, FoodType type)
            {
                this.weight = weight;
                this.type = type;
            }

            public int Weight { get => weight; set => weight = value; }
            public FoodType type { get => type; set => type = value; }

            public double ProteinT { get => this.weight*type.protein/100; set => type.protein = value; }
            public double CarbsT { get => this.weight*type.carbs/100; set => type.carbs = value; }
            public double FatT

            public System.Type waaa()
            {
                return this.type;
            }

            public string toStringInGramms()
            {
              return "";
            }

        }
        static void Main(string[] args)
        {
            FoodType type = new FoodType("banana", 4, 93, 3) 
            Food food = new Food(110, type);
        }
    }
}
