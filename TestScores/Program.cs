using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    internal class Program
    {
        // Declare and initialize program constants
        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        const string STOPPROGRAM = "-999";

        // Delcare and initialize class variables
        static int currentScore = 0;
        static int scoreTotal = 0;
        static int scoreCount = 0;
        static decimal scoreAverage = 0m;

        static void Main(string[] args)
        {
            while (currentScore.ToString() != STOPPROGRAM)
            {
                InputTestScore();
                UpdateTotals();
                PrintAllStatistics();
            }
        }

        static void InputTestScore()
        {
            Clear();
            string scoreStr = "";
            bool result;

            // Input test score between 0 and 100
            Write($"Enter a test score between {MINSCORE} and {MAXSCORE} or {STOPPROGRAM} to end.\t");
            scoreStr = Console.ReadLine();

            // Check for empty test score input
            if (scoreStr.Trim() == "")
            {
                WriteLine("\nScore cannot be empty. Please try again. Enter key to retry...");
                ReadLine();

                InputTestScore();
            }

            // Check for -999 input program end
            if (scoreStr == STOPPROGRAM)
            {
                WriteLine("Exiting program...");
                Environment.Exit(0);
            }

            // There is input and isnt -999
            // Check for non-numeric or OOR test score
            result = int.TryParse(scoreStr, out currentScore);

            if (!result || currentScore < MINSCORE || currentScore > MAXSCORE)
            {
                WriteLine("\nNon-numeric or out of range score input. Please try again. Enter key to retry...");
                ReadLine();

                InputTestScore();
            }

        }

        static void UpdateTotals()
        {
            // Add 1 to score count
            scoreCount++;

            // Add current score to total score
            scoreTotal += currentScore;

            // Calculate current average
            // scoreTotal / scoreCount
            scoreAverage = (decimal)scoreTotal / scoreCount;

        }

        static void PrintAllStatistics()
        {
            WriteLine($"\n\nScore:\t\t{currentScore}");
            WriteLine($"Score Total:\t{scoreTotal}");
            WriteLine($"Score Count:\t{scoreCount}");
            WriteLine($"Score Average:\t{scoreAverage:n2}");
            WriteLine("\nEnter key to continue inputting scores...");

            ReadLine();
        }
    }
}
