using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = "";
            do
            {
                Console.WriteLine("Hello, welcome to the lucky numbers game."); // initial greeting
                Console.WriteLine("The jackpot is 300,000.");
                Console.WriteLine("To get started, please enter the lowest number in the range.");
                int rangeLow = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the highest number in the range.");
                int rangeHigh = int.Parse(Console.ReadLine());
                int[] userNumberSet = new int[6];
                for (int i =0; i <userNumberSet.Length; i++)
                {
                    Console.WriteLine("Please enter your guess.");
                    userNumberSet[i] = int.Parse(Console.ReadLine());
                    while ((userNumberSet[i] < rangeLow) || (userNumberSet[i] > rangeHigh))
                        {
                        Console.WriteLine("Please enter a valid number.");
                        userNumberSet[i] = int.Parse(Console.ReadLine());
                        }

                }
                Console.WriteLine("The numbers you chose are {0}, {1}, {2}, {3}, {4}, {5}", userNumberSet[0], userNumberSet[1], userNumberSet[2], userNumberSet[3], userNumberSet[4], userNumberSet[5]);

                int[] lotteryNumberSet = new int[6];
                Random r = new Random();
                int numberCorrect = 0;
                for (int i =0; i<lotteryNumberSet.Length; i++)
                {
                    lotteryNumberSet[i] = r.Next(rangeLow, rangeHigh);
                    Console.WriteLine("Lucky Number : "+lotteryNumberSet[i]);
                }

                for (int i=0; i<lotteryNumberSet.Length; i++)
                {
                    if (lotteryNumberSet[i] == userNumberSet[0])
                    {
                        numberCorrect++;
                    }
                    else if (lotteryNumberSet[i] == userNumberSet[1])
                    {
                        numberCorrect++;
                    }
                    else if (lotteryNumberSet[i] == userNumberSet[2])
                    {
                        numberCorrect++;
                    }
                    else if (lotteryNumberSet[i] == userNumberSet[3])
                    {
                        numberCorrect++;
                    }
                    else if (lotteryNumberSet[i] == userNumberSet[4])
                    {
                        numberCorrect++;
                    }
                    else if (lotteryNumberSet[i] == userNumberSet[5])
                    {
                        numberCorrect++;
                    }

                }
                Console.WriteLine("You guessed " + numberCorrect + " correctly");
                Console.WriteLine("You won $" + Winnings(numberCorrect));
             
                Console.WriteLine("Would you like to play again? Type \"yes\" to continue or \"no\" to quit.");
                action = (Console.ReadLine().ToLower());

            } while (action != "no");

            Console.WriteLine("Thanks for playing!");
            
        }
        static double Winnings (int correctGuesses)
        {
            double lotteryWinnings = 300000 *(correctGuesses/6);

            return lotteryWinnings;
        }

    }
}
