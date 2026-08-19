namespace LongestIncreasingSubsequence;

public static class SequenceSolver
{
    public static string Find(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = Array.ConvertAll(parts, int.Parse);

        if (numbers.Length == 1)
            return numbers[0].ToString();

        int bestStart = 0;
        int bestLength = 1;

        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            // Increasing compared to the immediately previous element
            if (numbers[i] > numbers[i - 1])
            {
                currentLength++;

                // Only update on strictly greater length.
                // Therefore, if there is a tie, the earliest
                // sequence is retained.
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStart = currentStart;
                }
            }
            else
            {
                // Increasing sequence has ended.
                currentStart = i;
                currentLength = 1;
            }
        }

        List<int> result = new List<int>();

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            result.Add(numbers[i]);
        }

        return string.Join(" ", result);
    }
}
