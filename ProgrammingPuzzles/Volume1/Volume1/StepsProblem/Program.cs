using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int n = 4; // total number of steps on the ladder
            int m = 3; // max steps taken by the child

            List<List<int>> resultSteps = GetStepsCombinations(n, m);

            foreach (var combination in resultSteps)
            {
                foreach (var step in combination)
                {
                    Console.Write(step);
                }
                Console.WriteLine();
            }
        }

        private static List<List<int>> GetStepsCombinations(int n, int m)
        {
            List<List<int>> resultSteps = new List<List<int>>();

            for (int i = 1; i <= m; i++)
            {
                if ((n - i) == 0)
                {
                    var singleCombination = new List<int>();
                    singleCombination.Add(i);
                    resultSteps.Add(singleCombination);
                    return resultSteps;

                }
                var subResultSteps = GetStepsCombinations(n - i, m);
                foreach (var combination in subResultSteps)
                {
                    combination.Add(i);
                    resultSteps.Add(combination);
                }
            }
            return resultSteps;
        }
    }
}
