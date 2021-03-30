using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSum = 0;
            int sequenceCouter = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            while((input = Console.ReadLine()) != "Clone them!" )
            {
                int currentLength = 1;
                int bestSequenceLength = 1;
                int startIndex = 0;
                int sequenceSum = 0;

                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCouter++;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                    if (currentLength > bestSequenceLength)
                    {
                        bestSequenceLength = currentLength;
                        startIndex = i;
                    }
                    sequenceSum += currentSequence[i];
                }

                sequenceSum += currentSequence[n - 1];

                if (bestSequenceLength > bestLength)
                {
                    bestLength = bestSequenceLength;
                    bestStartIndex = startIndex;
                    bestSum = sequenceSum;
                    bestSequenceIndex = sequenceCouter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (bestSequenceLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestSequenceLength;
                        bestStartIndex = startIndex;
                        bestSum = sequenceSum;
                        bestSequenceIndex = sequenceCouter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (sequenceSum > bestSum)
                        {
                            bestLength = bestSequenceLength;
                            bestStartIndex = startIndex;
                            bestSum = sequenceSum;
                            bestSequenceIndex = sequenceCouter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
