using System;

namespace Game
{
    class DiceRoll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roll Game!\nWhich game mode would you like to play?\n" +
                "\t1. Basic mode\n\t2. Play with Doubles\n\t3. Play with Triples\n\t4. Play it all!\n\t5. Exit");
            int choice;
            do
            {
                Console.WriteLine("\nType in a number please.");
                string input = Console.ReadLine();

                int.TryParse(input, out choice);

                switch (choice)
                {
                    case 1:
                        threeRolls();
                        break;
                    case 2:
                        playDoubles();
                        break;
                    case 3:
                        playTriples();
                        break;
                    case 4:
                        playAll();
                        break;
                    case 5:
                        Console.WriteLine("\nPlease play again next time!");
                        break;
                    default:
                        Console.WriteLine("\nYou did not enter a number. Try again next time!");
                        choice = 5;
                        break;
                }
            }
            while (choice != 5);

  
        }
         static void threeRolls()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if (total > 14)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }

        static void playDoubles()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }

        static void playTriples()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }

        static void playAll()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }
    }
}
