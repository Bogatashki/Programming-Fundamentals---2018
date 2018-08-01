using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            double totalCalories = volume * energyContent / 100.0;
            double totalSugars = volume * sugarContent / 100;
            Console.WriteLine($"{totalCalories}kcal, {totalSugars}g sugars");
        }
    }
}
