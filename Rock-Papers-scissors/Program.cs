using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Papers_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rounds do you want to play ? : ");
            int numberOfRounds = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            string[] hands = { "Rock", "Paper", "Sci" };
            int playerPoints = 0;
            int computerPoints = 0;
            for (int counter = 1; counter <= numberOfRounds; counter++)
            {
                Console.Write("Player Hand : ");
                string playerHand = Console.ReadLine();
                int randomNumber = rnd.Next(0, 3);
                string computerHand = hands[randomNumber];
                Console.WriteLine("Computer Hand : " + computerHand);

                switch (playerHand)
                {
                    case "Rock":
                        if (computerHand == "Rock")
                        {
                            playerPoints++;
                            computerPoints++;
                            Console.WriteLine("Player And Computer Win a Point");
                            Console.WriteLine();
                        }
                        if (computerHand == "Paper")
                        {
                            computerPoints++;
                            Console.WriteLine("Computer wins a point");
                            Console.WriteLine();
                        }
                        if (computerHand == "Sci")
                        {
                            playerPoints++;
                            Console.WriteLine("Player wins a point");
                            Console.WriteLine();
                        }
                        break;

                    case "Paper":
                        if (computerHand == "Paper")
                        {
                            playerPoints++;
                            computerPoints++;
                            Console.WriteLine("Player and Computer Win a Point");
                            Console.WriteLine();
                        }
                        if (computerHand == "Sci")
                        {
                            computerPoints++;
                            Console.WriteLine("Computer wins a point");
                            Console.WriteLine();
                        }
                        if (computerHand == "Rock")
                        {
                            playerPoints++;
                            Console.WriteLine("Player wins a point");
                            Console.WriteLine();
                        }
                        break;

                    case "Sci":
                        if (computerHand == "Sci")
                        {
                            playerPoints++;
                            computerPoints++;
                            Console.WriteLine("Player and Computer Win a Point");
                            Console.WriteLine();
                        }
                        if (computerHand == "Rock")
                        {
                            computerPoints++;
                            Console.WriteLine("Computer wins a point");
                            Console.WriteLine();
                        }
                        if (computerHand == "Paper")
                        {
                            playerPoints++;
                            Console.WriteLine("Player wins a point");
                            Console.WriteLine();
                        }
                        break;
                }
            }
            Console.WriteLine("*** RESULTS ***");
            Console.WriteLine("Player Points : " + playerPoints);
            Console.WriteLine("Computer Points : " + computerPoints);

            if (playerPoints > computerPoints)
            {
                Console.WriteLine("Player Wins");
            }
            else
            {
                if (computerPoints > playerPoints)
                {
                    Console.WriteLine("Computer Wins");
                }
                else
                {
                    Console.WriteLine("Equal None Win");
                }
            }

            Console.ReadLine();
        }
    }
}
