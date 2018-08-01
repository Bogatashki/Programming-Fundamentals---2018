using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumner = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            string debitCardNumber = $"{firstNumber:D4} {secondNumner:D4} {thirdNumber:D4} {forthNumber:D4}";
            Console.WriteLine(debitCardNumber);
        }
    }
}
