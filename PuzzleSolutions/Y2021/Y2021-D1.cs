using ChallengeSolutions.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSolutions.Y2021
{
    public static class Y2021_D1
    {
        public static string SolvePart1()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);
            int length = puzzleInput.Count;
            int increased = 0;
            for (int i = 1; i < length; i++)
            {
                if (puzzleInput[i] > puzzleInput[i - 1])
                {
                    increased += 1;
                }
                
            }
            Console.WriteLine(increased);
            return "I Haven't Solved part 1 yet!";
        }

        public static string SolvePart2()
        {
            return "I Haven't Solved part 2 yet!";
        }
    }
}
