using System;

namespace randomgame
{
   class Program
    {
        static void Main()
        {
            int playerNumber = 0;
            bool gameOver = false;
            Random random = new Random();
            Console.WriteLine("Hello here are the rules of the game\n1: This is an infinite game so you can keep playing until you want it to end\n2: If you want the game to end just type -1\n3: You have to type the number 1 higher than ur current number in order to keep playing the game\n4: If you type an invalid number you will lose\n5: you will have to choose between 4 options A, B, C and D\n6: Have fun and enjoy yourself");

            while (!gameOver)
            {
                // Generate four random numbers between 0 and 9
                int[] numbers = new int[4];
                int higherNumberIndex = random.Next(0, 4); // Index for the number one higher than the current player number

                for (int i = 0; i < 4; i++)
                {
                    if (i == higherNumberIndex)
                    {
                        numbers[i] = playerNumber + 1; // One higher than the current player number
                    }
                    else
                    {
                        numbers[i] = random.Next(0, 10);
                    }
                }

                // Shuffle the order of the numbers
                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    int j = random.Next(0, i + 1);
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }

                Console.WriteLine("Current number: " + playerNumber);
                Console.WriteLine("Choose a number: ");
                Console.WriteLine("A: " + numbers[0]);
                Console.WriteLine("B: " + numbers[1]);
                Console.WriteLine("C: " + numbers[2]);
                Console.WriteLine("D: " + numbers[3]);
                Console.WriteLine("Type 'A', 'B', 'C', or 'D' to choose a number.");

                string userInput = Console.ReadLine().ToUpper();

                if (userInput == "-1")
                {
                    gameOver = true;
                }
                else if (userInput == "A" && numbers[0] == playerNumber + 1)
                {
                    playerNumber++;
                }
                else if (userInput == "B" && numbers[1] == playerNumber + 1)
                {
                    playerNumber++;
                }
                else if (userInput == "C" && numbers[2] == playerNumber + 1)
                {
                    playerNumber++;
                }
                else if (userInput == "D" && numbers[3] == playerNumber + 1)
                {
                    playerNumber++;
                }
                else
                {
                    Console.WriteLine("You lost! Incorrect input or the number is not available.");
                    gameOver = true;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

    }
}
