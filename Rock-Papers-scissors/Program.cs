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
        }
    }
}
