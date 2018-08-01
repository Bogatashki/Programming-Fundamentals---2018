using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            int remainingHealth = maxHealth - currentHealth;
            string currentHealthString = new string('|', currentHealth);
            string remainingHealthString = new string('.', remainingHealth);
            string healthBar = $"Health: |{currentHealthString}{remainingHealthString}|";
            Console.WriteLine(healthBar);

            int remainingEnergy = maxEnergy - currentEnergy;
            string currentEnergyString = new string('|', currentEnergy);
            string remainingEnergyString = new string('.', remainingEnergy);
            string energyBar = $"Energy: |{currentEnergyString}{remainingEnergyString}|";
            Console.WriteLine(energyBar);
        }
    }
}
