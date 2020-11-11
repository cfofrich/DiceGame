using System;


namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice simulator. Please enter the amount of dice you would like to cast (Press Q to quit) >>");

            string diceString = "";

            while (diceString != "Q")
            {
                diceString = Console.ReadLine();

                if (diceString == "Q")
                {
                    break;
                }

                int diceInput = Convert.ToInt32(diceString);

                for (int index = 0; index < diceInput; index++)
                {
                    Random random = new Random();
                    int diceRoll = random.Next(6) + 1;

                    Console.WriteLine(diceRoll);

                }
                Console.WriteLine("Enter another amount of dice to case or 'Q' to quit >>");
            }

            

        }

    }
}
